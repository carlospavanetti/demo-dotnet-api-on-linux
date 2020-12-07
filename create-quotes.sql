-- sqlcmd -S localhost -U SA -P <password> -i create-quotes.sql

CREATE DATABASE QuotesExample;
GO

USE QuotesExample;
GO

CREATE TABLE dbo.Quotes(
    Symbol char(3) NOT NULL,
    Currency varchar(30) NOT NULL,
    LastQuote datetime NOT NULL,
    Price numeric (18,4) NOT NULL,
    CONSTRAINT PK_Quotes PRIMARY KEY (Symbol)
);
GO
