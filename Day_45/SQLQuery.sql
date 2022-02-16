-- yvela klienti visac gaachnia rogorc sesxi aseve deposit.

SELECT * FROM Customers as c
INNER JOIN loan.Loans as l
ON c.CustomerID = l.CustomerID
INNER JOIN Deposits as d
ON c.CustomerID = d.CustomerID

-- sesxebze da depositebze gavaketot 4-ve join, da avxsnat ra gansxvavebul shedegs mogvcems titoeuli.


-- 603 row, mxolod isini visac depozitic aqvs da sesxic. (venis diagramit tanakveta)
SELECT * FROM Deposits d
INNER JOIN loan.Loans l
ON d.CustomerID = l.CustomerID


-- yvela depozitis mqone da aseve isinic visac orive aq (venis diagramit marcxena mtlianad)
SELECT * FROM Deposits d
LEFT JOIN loan.Loans l
ON d.CustomerID = l.CustomerID


-- yvela sesxis mqone da aseve isini visac depozitic aq da sesxic ( venis diagramit marjvena mtlianad)
SELECT * FROM Deposits d
RIGHT JOIN loan.Loans l
ON d.CustomerID = l.CustomerID


-- yvela :D (venis diagramit orive wre) yvela sesxis da yvela depositis mqone xalxi, (bunebrivia visac orive aqvs isinic)
SELECT * FROM Deposits d
FULL JOIN loan.Loans l
ON d.CustomerID = l.CustomerID

-- vigeb im momxmareblebs romlebsac sesxi aq, vukavshireb eqauntebs, zogs sheidzleba 7 aqvs, amitom duplicate iqneba, zogs saertod ar qondes
-- marcxnidan vabam overdraftebs im klientebze romlebsac aqvs ( romelsac ara null)
SELECT * FROM Customers as c
LEFT JOIN Accounts as a
ON a.CustomerID = c.CustomerID
LEFT JOIN OverDrafts as od
ON a.AccountID = od.AccountID
INNER JOIN loan.Loans as l
ON c.CustomerID = l.CustomerID

-- gavaketot usafudzvlo, arafrismomcemi, uintereso, drois tyuilad damkargavi da amazrzeni join

SELECT * FROM Customers as c
LEFT/*ABSURD JOIN*/ JOIN Transactions t
ON t.DebitAccountID = c.CustomerID

/*
Customers >> Accounts -> erti bevrtan. ert customers sheidzleba bevri account qondes magram erti account aucileblad ert pirovnebas ekutvnis
Customers >> Loans -> rogorc lasham tqva tu shesadzlebelia rom erti sesxi orma adamianma aigos mashin many2many, sxva shemtxvevashi one2many
Loans >> LoanAccouns -> 
Customer >> Deposits -> one 2 one - ert momxmarebels erti anabari aqvs, erti anabari  ert momxmarebels ekutvnis
Accounts >> Overdrafts -> one 2 many - ert angarishze bevri  overdraftis gaketeba shegidzlia, titoeuli overdrafti konkretul angarishs ekutvnis
Transactions >> Accounts -> many 2 many radgan ert transaction 2 eqaunti aq, eqauntze bevri transaction sheidzleba iyos 
TransactionTypes >> Transactions - one 2 many radgan erti transaction tipi sheidzleba bevr transaqciaze iqnes gamoyenebuli, ert transaqciaze erti konkretuli tipi gamoiyeneba
*/

SELECT 
c1.CustomerFirstName, c1.CustomerLastName,
c2.CustomerFirstName, c2.CustomerLastName FROM Transactions as t

INNER JOIN Accounts as a1
ON a1.AccountID = t.CreditAccountID
INNER JOIN Customers as c1
ON a1.CustomerID = c1.CustomerID
INNER JOIN Accounts AS a2
ON a2.AccountID = t.DebitAccountID
INNER JOIN Customers c2
ON a2.CustomerID = c2.CustomerID


SELECT c.CustomerFirstName, c.CustomerLastName 
FROM  Customers c,Deposits d,loan.Loans l
WHERE c.CustomerID = d.CustomerID AND c.CustomerID = l.CustomerID
GROUP BY c.CustomerFirstName, c.CustomerLastName


-- radgan 115 momxmarebels aqvs 9 sesxi da 2 anabari , join daagenerirebs yvela sesxs yvela anabartan, es gamova 9 * 2 am shemtxvevashi
SELECT * FROM loan.Loans as l
INNER JOIN Deposits as d 
ON l.CustomerID = d.CustomerID
WHERE l.CustomerID = 115

