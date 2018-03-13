#include <bits/stdc++.h>
#include <iostream>
#include <vector>
#include <cassert>
 
using namespace std;
 
#define pb push_back
 
typedef long long ll;
 
ll width = 60, depth = 1, finished, lastAns, needWork, n, m, k, cnt[61][61], ans = -1, numberOfTries = 120, numberOfDays = 6, numberOfLessons = 7;
ll g[8][7][61], t[8][7][61], sumGroup[61], sumTeacher[61];
ll gg[8][7][61], tt[8][7][61], didWork[61][61], lectureHall[8][7];
 
struct item {
    ll sum, pos, typ;
}order[122];
 
struct movee {
    ll x, y, teacher, cost;
}curMove;
 
void init() {
    for (ll i = 1; i <= n; i++)
        for (ll j = 1; j <= m; j++) {
            sumGroup[i] += cnt[i][j];
            sumTeacher[j] += cnt[i][j];
        }
}
 
void clear() {
    // N*M + (N+M)*42
    lastAns = 0;
    finished = 1;
    for (ll i = 1; i <= numberOfLessons; i++)
        for (ll j = 1; j <= numberOfDays; j++)
            lectureHall[i][j] = 0;
    for (ll i = 1; i <= n; i++)
        for (ll j = 1; j <= m; j++)
            didWork[i][j] = 0;
    for (ll q = 1; q <= n; q++)
        for (ll i = 1; i <= numberOfLessons; i++)
            for (ll j = 1; j <= numberOfDays; j++)
                gg[i][j][q] = 0;
    for (ll q = 1; q <= m; q++)
        for (ll i = 1; i <= numberOfLessons; i++)
            for (ll j = 1; j <= numberOfDays; j++)
                tt[i][j][q] = 0;
}
 
void print() {
    cout << ans << endl;
    for (ll q = 1; q <= n; q++) {
        cout << endl;
        for (ll i = 1; i <= numberOfLessons; i++) {
            for (ll j = 1; j <= numberOfDays; j++)
                cout << g[i][j][q] << " ";
            cout << endl;
        }
    }
}
 
void tryRelax() {
    if (finished) {
        ll cost = lastAns;
        if (ans == -1 || ans > cost) {
            ans = cost;
            copy(&gg[0][0][0], &gg[0][0][0] + 3416, &g[0][0][0]);
            copy(&tt[0][0][0], &tt[0][0][0] + 3416, &t[0][0][0]);
        }
    }
}
 
bool cmp(item a, item b) {
    return a.sum > b.sum;
}
 
bool cmp2(movee a, movee b) {
    return a.cost < b.cost;
}
 
movee dfs(ll currentGroup, ll needWork, ll curAns, ll dep) {
    if (needWork == 0 || dep > depth) {
        movee ans;
        ans.x = ans.y = ans.teacher = 0;
        ans.cost = curAns;
        assert(curAns > -1);
        return ans;
    }
    ll count, best = -1, pos, curCost, gx, gy, tx, ty, oldG, newG, oldT, newT, calc, cost;
    vector<movee> moves;
    for (ll currentTeacher = 1; currentTeacher <= m; currentTeacher++)
        if (didWork[currentGroup][currentTeacher] < cnt[currentGroup][currentTeacher]) {
            for (ll i = 1; i <= numberOfLessons; i++)
                for (ll j = 1; j <= numberOfDays; j++)
                    if (lectureHall[i][j] < k && gg[i][j][currentGroup] == 0 && tt[i][j][currentTeacher] == 0) {
                        gy = ty = 0;
                        gx = tx = 8;
                        for (ll ii = 1; ii <= numberOfLessons; ii++) {
                            if (gg[ii][j][currentGroup] > 0)
                                gy = ii;
                            if (gy > 0 && gx == 8)
                                gx = gy;
                            if (tt[ii][j][currentTeacher] > 0)
                                ty = ii;
                            if (ty > 0 && tx == 8)
                                tx = ty;
                        }
                        oldG = oldT = newG = newT = 0;
                        if (gy > 0)
                            oldG = (gy - gx + 3) * (gy - gx + 3);
                        if (ty > 0)
                            oldT = (ty - tx + 3) * (ty - tx + 3);
                        if (gx > i)
                            gx = i;
                        if (gy < i)
                            gy = i;
                        if (tx > i)
                            tx = i;
                        if (ty < i)
                            ty = i;
                        newG = (gy - gx + 3) * (gy - gx + 3);
                        newT = (ty - tx + 3) * (ty - tx + 3);
                        cost = curAns + newT - oldT + newG - oldG;
                        curMove.x = i, curMove.y = j;
                        curMove.cost = cost;
                        curMove.teacher = currentTeacher;
                        moves.pb(curMove);
                    }
        }
    sort(moves.begin(), moves.end(), &cmp2);
    if (moves.empty()) {
        movee last;
        last.x = last.y = last.teacher = 0;
        last.cost = curAns;
        return last;
    }
    movee beest;
    count = min(width, (ll)moves.size());
    movee that;
    for (ll i = 0; i < count; i++) {
        that = moves[i];
        gg[that.x][that.y][currentGroup] = that.teacher;
        tt[that.x][that.y][that.teacher] = currentGroup;
        lectureHall[that.x][that.y]++;
        didWork[currentGroup][that.teacher]++;
        cost = that.cost;
 
        beest = dfs(currentGroup, needWork - 1, cost, dep + 1);
 
        if (beest.cost > -1 && (beest.cost < best || best == -1))
            best = beest.cost, pos = i;
        gg[that.x][that.y][currentGroup] = tt[that.x][that.y][that.teacher] = 0;
        lectureHall[that.x][that.y]--;
        didWork[currentGroup][that.teacher]--;
    }
    if (best == -1)
        assert(0);
    return moves[pos];
}
 
movee dffs(ll currentTeacher, ll needWork, ll curAns, ll dep) {
    if (needWork == 0 || dep > depth) {
        movee ans;
        ans.x = ans.y = ans.teacher = 0;
        ans.cost = curAns;
        assert(curAns > -1);
        return ans;
    }
    ll count, best = -1, pos, curCost, gx, gy, tx, ty, oldG, newG, oldT, newT, calc, cost;
    vector<movee> moves;
    for (ll currentGroup = 1; currentGroup <= n; currentGroup++)
        if (didWork[currentGroup][currentTeacher] < cnt[currentGroup][currentTeacher]) {
            for (ll i = 1; i <= numberOfLessons; i++)
                for (ll j = 1; j <= numberOfDays; j++)
                    if (lectureHall[i][j] < k && gg[i][j][currentGroup] == 0 && tt[i][j][currentTeacher] == 0) {
                        gy = ty = 0;
                        gx = tx = 8;
                        for (ll ii = 1; ii <= numberOfLessons; ii++) {
                            if (gg[ii][j][currentGroup] > 0)
                                gy = ii;
                            if (gy > 0 && gx == 8)
                                gx = gy;
                            if (tt[ii][j][currentTeacher] > 0)
                                ty = ii;
                            if (ty > 0 && tx == 8)
                                tx = ty;
                        }
                        oldG = oldT = newG = newT = 0;
                        if (gy > 0)
                            oldG = (gy - gx + 3) * (gy - gx + 3);
                        if (ty > 0)
                            oldT = (ty - tx + 3) * (ty - tx + 3);
                        if (gx > i)
                            gx = i;
                        if (gy < i)
                            gy = i;
                        if (tx > i)
                            tx = i;
                        if (ty < i)
                            ty = i;
                        newG = (gy - gx + 3) * (gy - gx + 3);
                        newT = (ty - tx + 3) * (ty - tx + 3);
                        cost = curAns + newT - oldT + newG - oldG;
                        curMove.x = i, curMove.y = j;
                        curMove.cost = cost;
                        curMove.teacher = currentGroup;
                        moves.pb(curMove);
                    }
        }
    sort(moves.begin(), moves.end(), &cmp2);
    if (moves.empty()) {
        movee last;
        last.x = last.y = last.teacher = 0;
        last.cost = curAns;
        return last;
    }
    movee beest;
    count = min(width, (ll)moves.size());
    movee that;
    for (ll i = 0; i < count; i++) {
        that = moves[i];
        gg[that.x][that.y][that.teacher] = currentTeacher;
        tt[that.x][that.y][currentTeacher] = that.teacher;
        lectureHall[that.x][that.y]++;
        didWork[that.teacher][currentTeacher]++;
        cost = that.cost;
 
        beest = dffs(currentTeacher, needWork - 1, cost, dep + 1);
 
        if (beest.cost > -1 && (beest.cost < best || best == -1))
            best = beest.cost, pos = i;
        gg[that.x][that.y][that.teacher] = tt[that.x][that.y][currentTeacher] = 0;
        lectureHall[that.x][that.y]--;
        didWork[that.teacher][currentTeacher]--;
    }
    if (best == -1)
        assert(0);
    return moves[pos];
}
 
void fillRemaining(ll currentGroup, ll needWork) {
    ll oldAns = lastAns, oldG, newG, oldT, newT, gx, gy, tx, ty, ans = -1, whichTeacher, whichDay, whichLesson, cost;
    while (needWork) {
        movee cur = dfs(currentGroup, needWork, oldAns, 0);
        if(cur.cost == -1)
            break;
        else
        {
            lectureHall[cur.x][cur.y]++;
            gg[cur.x][cur.y][currentGroup] = cur.teacher;
            tt[cur.x][cur.y][cur.teacher] = currentGroup;
            didWork[currentGroup][cur.teacher]++;
            needWork--;
            oldAns = cur.cost;
        }
    }
    lastAns = oldAns;
    finished &= (needWork == 0);
}
 
void fillTeacher(ll currentTeacher, ll needWork) {
    ll oldAns = lastAns, oldG, newG, oldT, newT, gx, gy, tx, ty, ans = -1, whichTeacher, whichDay, whichLesson, cost;
    while (needWork) {
        movee cur = dffs(currentTeacher, needWork, oldAns, 0);
        if(cur.cost == -1)
            break;
        else
        {
            lectureHall[cur.x][cur.y]++;
            gg[cur.x][cur.y][cur.teacher] = currentTeacher;
            tt[cur.x][cur.y][currentTeacher] = cur.teacher;
            didWork[cur.teacher][currentTeacher]++;
            needWork--;
            oldAns = cur.cost;
        }
    }
    lastAns = oldAns;
    finished &= (needWork == 0);
}
 
int main() {
    //freopen("02.txt", "r", stdin);
 
    cin >> n >> m >> k;
    for (ll i = 1; i <= n; i++)
        for (ll j = 1; j <= m; j++)
            cin >> cnt[i][j];
    init();
    for (ll i = 1; i <= n; i++)
        order[i].pos = i, order[i].sum = sumGroup[i];
    sort(order + 1, order + n + 1, &cmp);
    clear();
    for (ll i = 1; i <= n; i++) {
        needWork = 0;
        for (ll j = 1; j <= m; j++)
            needWork += cnt[order[i].pos][j] - didWork[order[i].pos][j];
        fillRemaining(order[i].pos, needWork);
    }
    tryRelax();
    for (ll i = 1; i <= m; i++)
        order[i].pos = i, order[i].sum = sumTeacher[i], order[i].typ = 2;
    sort(order + 1, order + m + 1, &cmp);
    clear();
    for (ll i = 1; i <= m; i++) {
        needWork = 0;
        for (ll j = 1; j <= n; j++)
            needWork += cnt[j][order[i].pos] - didWork[j][order[i].pos];
        fillTeacher(order[i].pos, needWork);
    }
    tryRelax();
    print();
}
