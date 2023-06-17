
--Write an SQL statement to select all articles with their author¡¦s email.
SELECT Article.Id AS ID, Article.Title, Article.Content, Users.Email AS Author_Email
FROM Article
JOIN Users ON Article.AuthorId = Users.Id;

-- Write another SQL statement to select articles from 7th to 12th sorted by id
SELECT *
FROM Article
ORDER BY Id
OFFSET 6 ROWS FETCH NEXT 6 ROWS ONLY;