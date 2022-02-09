
-- amoige yvela iuridiuli momxmarebeli arizonadan da coloradodan, da aseve isinic vinc washington cxovrobs

select * from Customers
where IsJuridical = 1 and (State = 'Arizona' or State = 'Colorado') or City = 'Washington'

-- wamomiye tanxa da valuta yvelasi romlis interesis machvenebeli ar aris 4 ze didi da ar aqvs state 2, aseve yvela iseti romlis product id aris 4
select Amount, Currency from Deposits
where not InterestRate > 4.0 and State = 2 or ProductID = 4

-- wamoige is xalxi romlebmac angarishi 2015 wlis 3 martidan 17 noembramde gaaketes
select CustomerId, OpenDate from Accounts
Where OpenDate between '2015-03-03' and '2015-11-17';

-- wamoige iseti momxmareblis id da gvari romlebic mtavrdeba on-ze
select CustomerID, CustomerLastName from Customers
where CustomerLastName like '%on'

-- wamoige momxmareblis(an momxmareblebis) saxeli da gvari romlis telefoni mtavrdeba 193-1341
select CustomerFirstName, CustomerLastName from Customers
where Phone like '%193-1341'

-- wamoige momxmareblis saxeli da gvari romlebic cxovroben baltimorshi an los angeles an irving
select CustomerFirstName, CustomerLastName from Customers
where City in ('Baltimore', 'Los Angeles', 'Irving')

-- wamoige imati saxeli da gvarebi visac angarishze sashualo raodenobaze meti tanxa aqvs
select CustomerFirstName, CustomerLastName from Customers
where CustomerID  in(
select CustomerID from Deposits 
where Amount > (select AVG(Amount) from Deposits)
)

-- wamoige tranzaqciis dro da debit/credit angarishis id ebi
select TransactionDate, DebitAccountID, CreditAccountID from Transactions
where Amount Between 5000 and 8000

-- wamoigebs unikalur qalaqebs da shtatebs momxmareblebidan (dublikatis gareshe)
select distinct City,[State] from Customers

-- machvene im momxmareblebis sruli customer/deposit informacia visac 47000 usd an meti  deposit aqvs gaketebuli
select * from Customers as c
inner join Deposits as d
on c.CustomerID = d.CustomerID
where amount > 47000

-- machvene yvela momxmareblis informacia, da visac deposit aqvs gaketebuli ertxel 
-- mainc depositis informaciac machvene, visac 3 jer aqvs samivejer machvene
select * from Customers as c
left join Deposits as d
on c.CustomerID = d.CustomerID

-- machvene yvela depositis informacia , im momxmareblebisac romelsac erti depoziti mainc aqvs gaketebuli
-- am shemtxvevashi yvela chanaweri momxmareblis mier aris amitom yvela chanawerze info brundeba
-- torem dabrundeboda null customer mxares. rows iqneba yoveltvis imdeni ramdeni depositic aris
select * from Customers as c
right join Deposits as d
on C.CustomerID = d.CustomerID

-- am shemtxvevashi dabrundeba customer yvela da deposit yvela informacia, vinaidan deposit aris
-- qve simravle customeris dabrundeba 617 chanaweri
-- tu meore cxrili pirvelis qvesimravlea, am shemtxvevashi full join gavs left joins, right join gavs inner joins
select * from Customers as c
full join Deposits as d
on C.CustomerID = d.CustomerID