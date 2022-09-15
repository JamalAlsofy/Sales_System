CREATE TABLE [dbo].[mylogin] (
    [username]  VARCHAR (35) NOT NULL,
    [password]  VARCHAR (35) NOT NULL,
    [is_Active] BIT          NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);
