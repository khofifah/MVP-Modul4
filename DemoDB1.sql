CREATE TABLE [dbo].[LOOKUPRole](   
    [LOOKUPRoleID] [int] IDENTITY(1,1) NOT NULL, 
    [RoleName] [varchar](100) DEFAULT '', 
    [RoleDescription] [varchar](500) DEFAULT '', 
    [RowCreatedSYSUserID] [int] NOT NULL, 
    [RowCreatedDateTime] [datetime]  DEFAULT GETDATE(), 
    [RowModifiedSYSUserID] [int] NOT NULL, 
    [RowModifiedDateTime] [datetime] DEFAULT GETDATE(), 
PRIMARY KEY (LOOKUPRoleID)   
    )

INSERT INTO LOOKUPRole (RoleName,RoleDescription,RowCreatedSYSUserID,RowModifiedSYSUserID)   
       VALUES ('Admin','Can Edit, Update, Delete',1,1) 
INSERT INTO LOOKUPRole (RoleName,RoleDescription,RowCreatedSYSUserID,RowModifiedSYSUserID)   
       VALUES ('Member','Read only',1,1)

CREATE TABLE [dbo].[SYSUser](   
    [SYSUserID] [int] IDENTITY(1,1) NOT NULL, 
    [LoginName] [varchar](50) NOT NULL, 
    [PasswordEncryptedText] [varchar](200) NOT NULL, 
    [RowCreatedSYSUserID] [int] NOT NULL, 
    [RowCreatedDateTime] [datetime] DEFAULT GETDATE(), 
    [RowModifiedSYSUserID] [int] NOT NULL, 
    [RowMOdifiedDateTime] [datetime] DEFAULT GETDATE(), 
    PRIMARY KEY (SYSUserID) 
)

CREATE TABLE [dbo].[SYSUserProfile](   
    [SYSUserProfileID] [int] IDENTITY(1,1) NOT NULL, 
    [SYSUserID] [int] NOT NULL, 
    [FirstName] [varchar](50) NOT NULL, 
    [LastName] [varchar](50) NOT NULL, 
    [Gender] [char](1) NOT NULL, 
    [RowCreatedSYSUserID] [int] NOT NULL, 
    [RowCreatedDateTime] [datetime] DEFAULT GETDATE(), 
    [RowModifiedSYSUserID] [int] NOT NULL, 
    [RowModifiedDateTime] [datetime] DEFAULT GETDATE(), 
    PRIMARY KEY (SYSUserProfileID) 
    )

ALTER TABLE [dbo].[SYSUserProfile]  WITH CHECK ADD FOREIGN KEY([SYSUserID])   
REFERENCES [dbo].[SYSUser] ([SYSUserID])

CREATE TABLE [dbo].[SYSUserRole](   
    [SYSUserRoleID] [int] IDENTITY(1,1) NOT NULL, 
    [SYSUserID] [int] NOT NULL, 
    [LOOKUPRoleID] [int] NOT NULL, 
    [IsActive] [bit] DEFAULT (1), 
    [RowCreatedSYSUserID] [int] NOT NULL, 
    [RowCreatedDateTime] [datetime] DEFAULT GETDATE(), 
    [RowModifiedSYSUserID] [int] NOT NULL, 
    [RowModifiedDateTime] [datetime] DEFAULT GETDATE(), 
    PRIMARY KEY (SYSUserRoleID) 
)

ALTER TABLE [dbo].[SYSUserRole]  WITH CHECK ADD FOREIGN KEY([LOOKUPRoleID])   
REFERENCES [dbo].[LOOKUPRole] ([LOOKUPRoleID])

ALTER TABLE [dbo].[SYSUserRole]  WITH CHECK ADD FOREIGN KEY([SYSUserID])   
REFERENCES [dbo].[SYSUser] ([SYSUserID])