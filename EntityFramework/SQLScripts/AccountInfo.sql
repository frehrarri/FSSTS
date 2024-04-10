USE [Development]
GO

/****** Object:  Table [dbo].[AccountInfo]    Script Date: 4/9/2024 10:50:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AccountInfo](
	[AccountInfoID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	[RecoveryQuestion1] [varchar](200) NOT NULL,
	[RecoveryQuestion2] [varchar](200) NOT NULL,
	[RecoveryQuestion3] [varchar](200) NOT NULL,
	[RecoveryAnswer1] [varchar](200) NOT NULL,
	[RecoveryAnswer2] [varchar](200) NOT NULL,
	[RecoveryAnswer3] [varchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[RegistrationDate] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AccountInfo] PRIMARY KEY CLUSTERED 
(
	[AccountInfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AccountInfo] ADD  DEFAULT (getdate()) FOR [RegistrationDate]
GO


