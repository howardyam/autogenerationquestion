# **WebTechAssignment2023**

--- 

## **Description**
This is for Web Technology assignment.

---

## **Links**
- [GitHub](https://github.com/BCS21090011/WebTechAssignment2023.git)
- [Figma](https://www.figma.com/file/0grXPVhB7sIiSKGHO9Q1H9/Untitled?node-id=15%3A3&t=pVewqGUSb8sBxukY-1)

---

## **TODO**
- [ ] Create all webpages.
- [ ] Make the pages more presentable.
- [ ] Add the function to create the pdf file (both question and answer).
- [ ] Link to the database (online).
> - Currently link offline, need to have SSMS (this should help [^1]), create a database locally and link it first.
- [ ] Push the project online.
- [ ] Submit the project.

## **Pages needed**
- [ ] Login page
- [ ] Register page
- [ ] Main page
- [ ] User profile page
- [ ] Insert question page
- [ ] Choose topic page
- [ ] Create question paper page
  
## **Local database**
Codes to create database:
```MSSQL
select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN' 
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
    end
    as ConnectionString
from sys.server_principals
where name = suser_name()
```
If want to use local database, need to replace the `connectionString` in the pages using database [^2].
Can get `connectionString` from SSMS using these: [^3]
```MSSQL
select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN' 
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
    end
    as ConnectionString
from sys.server_principals
where name = suser_name()
```

## **References**
- [ChatGPT](https://chat.openai.com/chat)
- https://blog.csdn.net/weixin_43074474/article/details/105106894 [^1]
- https://stackoverflow.com/questions/10479763/how-to-get-the-connection-string-from-a-database [^3]

[^1]: https://blog.csdn.net/weixin_43074474/article/details/105106894
[^2]: Index.cshtml.cs, Index1.cshtml.cs, CreateQuestionPaper.cshtml.cs (will be)
[^3]: https://stackoverflow.com/questions/10479763/how-to-get-the-connection-string-from-a-database
