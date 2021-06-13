select * from authors
select title from titles where title_id not in (select title_id from sales)
select title ,concat(au_fname,' ',au_lname) Author_Name,state from titles t join titleauthor ta on t.title_id=ta.title_id
join authors a on a.au_id=ta.au_id
join sales s on s.title_id=t.title_id
where a.state='CA'

select pub_name ,avg(price) AveragePrice from publishers p join titles t
on p.pub_id=t.pub_id join sales s 
on t.title_id=s.title_id group by pub_name

select p.pub_name,concat(au_fname,' ',au_lname) AuthorName,t.title,(s.qty*t.price) SalesAmount
from publishers p join titles t on p.pub_id=t.pub_id
join titleauthor ta on ta.title_id=t.title_id
join authors a on a.au_id=ta.au_id 
join sales s on s.title_id=t.title_id


select concat(au_lname,' ',au_fname) Author_name, pub_name Publisher_name, title Book_name,(price*qty) Sale_amount
from authors a join
titleauthor ta on ta.au_id = a.au_id
join titles t on t.title_id = ta.title_id
join sales s on s.title_id = t.title_id
join publishers p on p.pub_id = t.pub_id

select p.pub_name PublisherName,count(emp_id) NumberOfEmployees from publishers p join employee e 
on p.pub_id=e.pub_id group by pub_name having count(emp_id)>2

select pub_name PublisherName,concat(au_fname,' ',au_lname) AuthorName from publishers p join titles t on p.pub_id=t.pub_id
join titleauthor ta on t.title_id=ta.title_id 
join authors a on a.au_id=ta.au_id
where p.pub_name='Algodata Infosystems'

select  concat(au_lname,' ',au_fname) Author_name from authors a
join titleauthor ta on ta.au_id = a.au_id
join titles t on t.title_id = ta.title_id
join publishers p on p.pub_id = t.pub_id
where pub_name = 'Algodata Infosystems'

select concat(fname,' ',lname) EmployeeName from employee where pub_id = (select pub_id from publishers where pub_name ='Algodata Infosystems')


