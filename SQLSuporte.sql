USE [dbSuporte]
USE [dbSuporte]
GO
ALTER TABLE [dbo].[tbUsuarioSetor] DROP CONSTRAINT [FK_dbo.tbUsuarioSetor_dbo.tbUsuario_IdUsuario]
GO
ALTER TABLE [dbo].[tbUsuarioSetor] DROP CONSTRAINT [FK_dbo.tbUsuarioSetor_dbo.tbSetor_IdSetor]
GO
ALTER TABLE [dbo].[tbUsuarioPerfil] DROP CONSTRAINT [FK_dbo.tbUsuarioPerfil_dbo.tbUsuario_IdUsuario]
GO
ALTER TABLE [dbo].[tbUsuarioPerfil] DROP CONSTRAINT [FK_dbo.tbUsuarioPerfil_dbo.tbPerfil_IdPerfil]
GO
ALTER TABLE [dbo].[tbSetor] DROP CONSTRAINT [FK_dbo.tbSetor_dbo.tbSetor_IdSetorPai]
GO
ALTER TABLE [dbo].[tbMotivo] DROP CONSTRAINT [FK_dbo.tbMotivo_dbo.tbTipoAtendimento_IdTipoAtendimento]
GO
ALTER TABLE [dbo].[tbLogDetalhe] DROP CONSTRAINT [FK_dbo.tbLogDetalhe_dbo.tbLog_IdLog]
GO
ALTER TABLE [dbo].[tbLog] DROP CONSTRAINT [FK_dbo.tbLog_dbo.tbLog_IdLogAnterior]
GO
ALTER TABLE [dbo].[tbComputador] DROP CONSTRAINT [FK_dbo.tbComputador_dbo.tbSetor_IdSetor]
GO
ALTER TABLE [dbo].[tbComputador] DROP CONSTRAINT [FK_dbo.tbComputador_dbo.tbMarca_IdMarca]
GO
ALTER TABLE [dbo].[tbChatUserRoom] DROP CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbUsuario_IdUserTo]
GO
ALTER TABLE [dbo].[tbChatUserRoom] DROP CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbUsuario_IdUserFrom]
GO
ALTER TABLE [dbo].[tbChatUserRoom] DROP CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbChatRoom_IdRoom]
GO
ALTER TABLE [dbo].[tbChatMessage] DROP CONSTRAINT [FK_dbo.tbChatMessage_dbo.tbUsuario_IdUser]
GO
ALTER TABLE [dbo].[tbChatMessage] DROP CONSTRAINT [FK_dbo.tbChatMessage_dbo.tbChatRoom_IdRoom]
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico] DROP CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbUsuario_IdUsuario]
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico] DROP CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbTipoTarefa_IdTipoTarefa]
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico] DROP CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbAtendimento_IdAtendimento]
GO
ALTER TABLE [dbo].[tbAtendimento] DROP CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbUsuario_IdSolicitante]
GO
ALTER TABLE [dbo].[tbAtendimento] DROP CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbTipoAtendimento_IdTipoAtendimento]
GO
ALTER TABLE [dbo].[tbAtendimento] DROP CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbSetor_IdSetorSolicitante]
GO
ALTER TABLE [dbo].[tbAtendimento] DROP CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbMotivo_IdMotivo]
GO
ALTER TABLE [dbo].[tbAtendimento] DROP CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbComputador_IdComputador]
GO
/****** Object:  Table [dbo].[tbUsuarioSetor]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbUsuarioSetor]
GO
/****** Object:  Table [dbo].[tbUsuarioPerfil]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbUsuarioPerfil]
GO
/****** Object:  Table [dbo].[tbUsuario]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbUsuario]
GO
/****** Object:  Table [dbo].[tbTipoTarefa]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbTipoTarefa]
GO
/****** Object:  Table [dbo].[tbTipoAtendimento]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbTipoAtendimento]
GO
/****** Object:  Table [dbo].[tbSolucao]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbSolucao]
GO
/****** Object:  Table [dbo].[tbSituacao]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbSituacao]
GO
/****** Object:  Table [dbo].[tbSistema]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbSistema]
GO
/****** Object:  Table [dbo].[tbSetor]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbSetor]
GO
/****** Object:  Table [dbo].[tbPerfil]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbPerfil]
GO
/****** Object:  Table [dbo].[tbMotivo]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbMotivo]
GO
/****** Object:  Table [dbo].[tbMarca]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbMarca]
GO
/****** Object:  Table [dbo].[tbLogDetalhe]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbLogDetalhe]
GO
/****** Object:  Table [dbo].[tbLog]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbLog]
GO
/****** Object:  Table [dbo].[tbComputador]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbComputador]
GO
/****** Object:  Table [dbo].[tbChatUserRoom]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbChatUserRoom]
GO
/****** Object:  Table [dbo].[tbChatRoom]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbChatRoom]
GO
/****** Object:  Table [dbo].[tbChatMessage]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbChatMessage]
GO
/****** Object:  Table [dbo].[tbAtendimentoHistorico]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbAtendimentoHistorico]
GO
/****** Object:  Table [dbo].[tbAtendimento]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[tbAtendimento]
GO
/****** Object:  Table [dbo].[Error]    Script Date: 14/07/2017 11:51:21 ******/
DROP TABLE [dbo].[Error]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 14/07/2017 11:51:21 ******/

GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Error]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Error](
	[IdError] [int]  IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[StackTrace] [nvarchar](max) NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Error] PRIMARY KEY CLUSTERED 
(
	[IdError] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbAtendimento]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAtendimento](
	[IdAtendimento] [int]  IDENTITY(1,1) NOT NULL,
	[IdSetorSolicitante] [int] NOT NULL,
	[IdTipoAtendimento] [int] NULL,
	[IdMotivo] [int] NULL,
	[IdComputador] [int] NULL,
	[DtCadastro] [datetime] NOT NULL,
	[TxProtocolo] [nvarchar](max) NOT NULL,
	[NuPrioridade] [int] NOT NULL,
	[IdSolicitante] [int] NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbAtendimento] PRIMARY KEY CLUSTERED 
(
	[IdAtendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbAtendimentoHistorico]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAtendimentoHistorico](
	[IdAtendimentoHistorico] [int]  IDENTITY(1,1) NOT NULL,
	[IdAtendimento] [int] NOT NULL,
	[IdUsuario] [int] NULL,
	[IdTipoTarefa] [int] NULL,
	[DtHistorico] [datetime] NOT NULL,
	[TxObservacao] [nvarchar](max) NULL,
	[NuTipo] [int] NOT NULL,
	[NuStatus] [int] NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbAtendimentoHistorico] PRIMARY KEY CLUSTERED 
(
	[IdAtendimentoHistorico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChatMessage]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChatMessage](
	[IdMessage] [int]  IDENTITY(1,1) NOT NULL,
	[IdRoom] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[TxMessage] [nvarchar](max) NULL,
	[DtCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.tbChatMessage] PRIMARY KEY CLUSTERED 
(
	[IdMessage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChatRoom]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChatRoom](
	[IdRoom] [int]  IDENTITY(1,1) NOT NULL,
	[IdUnique] [int] NOT NULL,
	[DtCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.tbChatRoom] PRIMARY KEY CLUSTERED 
(
	[IdRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbChatUserRoom]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChatUserRoom](
	[IdUserRoom] [int]  IDENTITY(1,1) NOT NULL,
	[IdRoom] [int] NOT NULL,
	[IdUserFrom] [int] NOT NULL,
	[DtCadastro] [datetime] NOT NULL,
	[IdUserTo] [int] NOT NULL DEFAULT ('00000000-0000-0000-0000-000000000000'),
 CONSTRAINT [PK_dbo.tbChatUserRoom] PRIMARY KEY CLUSTERED 
(
	[IdUserRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbComputador]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbComputador](
	[IdComputador] [int]  IDENTITY(1,1) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[IdSetor] [int] NULL,
	[DtGarantia] [datetime] NOT NULL,
	[TxComputador] [nvarchar](100) NOT NULL,
	[TxModelo] [nvarchar](50) NULL,
	[TxProcessador] [nvarchar](50) NULL,
	[TxHD] [nvarchar](25) NULL,
	[TxMemoria] [nvarchar](25) NULL,
	[TxTombo] [nvarchar](15) NULL,
	[NuTipo] [int] NULL,
	[NuTipoMemoria] [int] NULL,
	[NuStatus] [int] NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbComputador] PRIMARY KEY CLUSTERED 
(
	[IdComputador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbLog]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLog](
	[IdLog] [int]  IDENTITY(1,1) NOT NULL,
	[TxTabela] [nvarchar](50) NOT NULL,
	[IdChave] [int] NOT NULL,
	[NuAcao] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[DtTransacao] [datetime] NOT NULL,
	[TxUrl] [nvarchar](255) NOT NULL,
	[IpUsuario] [nvarchar](15) NOT NULL,
	[IdLogAnterior] [int] NULL,
 CONSTRAINT [PK_dbo.tbLog] PRIMARY KEY CLUSTERED 
(
	[IdLog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbLogDetalhe]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLogDetalhe](
	[IdLogDetalhe] [int]  IDENTITY(1,1) NOT NULL,
	[IdLog] [int] NOT NULL,
	[TxObjeto] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_dbo.tbLogDetalhe] PRIMARY KEY CLUSTERED 
(
	[IdLogDetalhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbMarca]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMarca](
	[IdMarca] [int]  IDENTITY(1,1) NOT NULL,
	[TxMarca] [nvarchar](50) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbMarca] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbMotivo]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMotivo](
	[IdMotivo] [int]  IDENTITY(1,1) NOT NULL,
	[IdTipoAtendimento] [int] NOT NULL,
	[TxMotivo] [nvarchar](150) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbMotivo] PRIMARY KEY CLUSTERED 
(
	[IdMotivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbPerfil]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPerfil](
	[IdPerfil] [int]  IDENTITY(1,1) NOT NULL,
	[TxPerfil] [nvarchar](200) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbPerfil] PRIMARY KEY CLUSTERED 
(
	[IdPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbSetor]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSetor](
	[IdSetor] [int]  IDENTITY(1,1) NOT NULL,
	[IdSetorPai] [int] NULL,
	[TxSetor] [nvarchar](200) NOT NULL,
	[IsArquiva] [bit] NULL,
	[NuSetor] [int] NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbSetor] PRIMARY KEY CLUSTERED 
(
	[IdSetor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbSistema]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSistema](
	[IdSistema] [int]  IDENTITY(1,1) NOT NULL,
	[TxSistema] [nvarchar](50) NOT NULL,
	[TxIdentificador] [nvarchar](50) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbSistema] PRIMARY KEY CLUSTERED 
(
	[IdSistema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbSituacao]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSituacao](
	[IdSituacao] [int]  IDENTITY(1,1) NOT NULL,
	[TxSituacao] [nvarchar](150) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbSituacao] PRIMARY KEY CLUSTERED 
(
	[IdSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbSolucao]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSolucao](
	[IdSolucao] [int]  IDENTITY(1,1) NOT NULL,
	[TxSolucao] [nvarchar](150) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbSolucao] PRIMARY KEY CLUSTERED 
(
	[IdSolucao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbTipoAtendimento]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoAtendimento](
	[IdTipoAtendimento] [int]  IDENTITY(1,1) NOT NULL,
	[TxTipoAtendimento] [nvarchar](150) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbTipoAtendimento] PRIMARY KEY CLUSTERED 
(
	[IdTipoAtendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbTipoTarefa]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoTarefa](
	[IdTipoTarefa] [int]  IDENTITY(1,1) NOT NULL,
	[TxTipoTarefa] [nvarchar](max) NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbTipoTarefa] PRIMARY KEY CLUSTERED 
(
	[IdTipoTarefa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuario]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuario](
	[IdUsuario] [int]  IDENTITY(1,1) NOT NULL,
	[TxNome] [nvarchar](150) NOT NULL,
	[TxSobreNome] [nvarchar](200) NOT NULL,
	[TxCpf] [nvarchar](14) NOT NULL,
	[TxEmail] [nvarchar](200) NOT NULL,
	[TxTelefone] [nvarchar](max) NULL,
	[TxObservacao] [nvarchar](max) NULL,
	[TxLogin] [nvarchar](100) NOT NULL,
	[TxSenha] [nvarchar](200) NOT NULL,
	[TxSalt] [nvarchar](200) NULL,
	[IsAtivo] [bit] NOT NULL,
	[Hits] [int] NULL,
	[DtCadastro] [datetime] NULL,
	[ConnectionId] [nvarchar](max) NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuarioPerfil]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuarioPerfil](
	[IdUsuarioPerfil] [int]  IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdPerfil] [int] NOT NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbUsuarioPerfil] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbUsuarioSetor]    Script Date: 14/07/2017 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuarioSetor](
	[IdUsuarioSetor] [int]  IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdSetor] [int] NOT NULL,
	[IsPrincipal] [bit] NULL,
	[IdLog] [int] NOT NULL,
 CONSTRAINT [PK_dbo.tbUsuarioSetor] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioSetor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbComputador_IdComputador] FOREIGN KEY([IdComputador])
REFERENCES [dbo].[tbComputador] ([IdComputador])
GO
ALTER TABLE [dbo].[tbAtendimento] CHECK CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbComputador_IdComputador]
GO
ALTER TABLE [dbo].[tbAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbMotivo_IdMotivo] FOREIGN KEY([IdMotivo])
REFERENCES [dbo].[tbMotivo] ([IdMotivo])
GO
ALTER TABLE [dbo].[tbAtendimento] CHECK CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbMotivo_IdMotivo]
GO
ALTER TABLE [dbo].[tbAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbSetor_IdSetorSolicitante] FOREIGN KEY([IdSetorSolicitante])
REFERENCES [dbo].[tbSetor] ([IdSetor])
GO
ALTER TABLE [dbo].[tbAtendimento] CHECK CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbSetor_IdSetorSolicitante]
GO
ALTER TABLE [dbo].[tbAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbTipoAtendimento_IdTipoAtendimento] FOREIGN KEY([IdTipoAtendimento])
REFERENCES [dbo].[tbTipoAtendimento] ([IdTipoAtendimento])
GO
ALTER TABLE [dbo].[tbAtendimento] CHECK CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbTipoAtendimento_IdTipoAtendimento]
GO
ALTER TABLE [dbo].[tbAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbUsuario_IdSolicitante] FOREIGN KEY([IdSolicitante])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbAtendimento] CHECK CONSTRAINT [FK_dbo.tbAtendimento_dbo.tbUsuario_IdSolicitante]
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbAtendimento_IdAtendimento] FOREIGN KEY([IdAtendimento])
REFERENCES [dbo].[tbAtendimento] ([IdAtendimento])
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico] CHECK CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbAtendimento_IdAtendimento]
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbTipoTarefa_IdTipoTarefa] FOREIGN KEY([IdTipoTarefa])
REFERENCES [dbo].[tbTipoTarefa] ([IdTipoTarefa])
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico] CHECK CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbTipoTarefa_IdTipoTarefa]
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbUsuario_IdUsuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbAtendimentoHistorico] CHECK CONSTRAINT [FK_dbo.tbAtendimentoHistorico_dbo.tbUsuario_IdUsuario]
GO
ALTER TABLE [dbo].[tbChatMessage]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbChatMessage_dbo.tbChatRoom_IdRoom] FOREIGN KEY([IdRoom])
REFERENCES [dbo].[tbChatRoom] ([IdRoom])
GO
ALTER TABLE [dbo].[tbChatMessage] CHECK CONSTRAINT [FK_dbo.tbChatMessage_dbo.tbChatRoom_IdRoom]
GO
ALTER TABLE [dbo].[tbChatMessage]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbChatMessage_dbo.tbUsuario_IdUser] FOREIGN KEY([IdUser])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbChatMessage] CHECK CONSTRAINT [FK_dbo.tbChatMessage_dbo.tbUsuario_IdUser]
GO
ALTER TABLE [dbo].[tbChatUserRoom]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbChatRoom_IdRoom] FOREIGN KEY([IdRoom])
REFERENCES [dbo].[tbChatRoom] ([IdRoom])
GO
ALTER TABLE [dbo].[tbChatUserRoom] CHECK CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbChatRoom_IdRoom]
GO
ALTER TABLE [dbo].[tbChatUserRoom]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbUsuario_IdUserFrom] FOREIGN KEY([IdUserFrom])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbChatUserRoom] CHECK CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbUsuario_IdUserFrom]
GO
ALTER TABLE [dbo].[tbChatUserRoom]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbUsuario_IdUserTo] FOREIGN KEY([IdUserTo])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbChatUserRoom] CHECK CONSTRAINT [FK_dbo.tbChatUserRoom_dbo.tbUsuario_IdUserTo]
GO
ALTER TABLE [dbo].[tbComputador]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbComputador_dbo.tbMarca_IdMarca] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[tbMarca] ([IdMarca])
GO
ALTER TABLE [dbo].[tbComputador] CHECK CONSTRAINT [FK_dbo.tbComputador_dbo.tbMarca_IdMarca]
GO
ALTER TABLE [dbo].[tbComputador]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbComputador_dbo.tbSetor_IdSetor] FOREIGN KEY([IdSetor])
REFERENCES [dbo].[tbSetor] ([IdSetor])
GO
ALTER TABLE [dbo].[tbComputador] CHECK CONSTRAINT [FK_dbo.tbComputador_dbo.tbSetor_IdSetor]
GO
ALTER TABLE [dbo].[tbLog]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbLog_dbo.tbLog_IdLogAnterior] FOREIGN KEY([IdLogAnterior])
REFERENCES [dbo].[tbLog] ([IdLog])
GO
ALTER TABLE [dbo].[tbLog] CHECK CONSTRAINT [FK_dbo.tbLog_dbo.tbLog_IdLogAnterior]
GO
ALTER TABLE [dbo].[tbLogDetalhe]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbLogDetalhe_dbo.tbLog_IdLog] FOREIGN KEY([IdLog])
REFERENCES [dbo].[tbLog] ([IdLog])
GO
ALTER TABLE [dbo].[tbLogDetalhe] CHECK CONSTRAINT [FK_dbo.tbLogDetalhe_dbo.tbLog_IdLog]
GO
ALTER TABLE [dbo].[tbMotivo]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbMotivo_dbo.tbTipoAtendimento_IdTipoAtendimento] FOREIGN KEY([IdTipoAtendimento])
REFERENCES [dbo].[tbTipoAtendimento] ([IdTipoAtendimento])
GO
ALTER TABLE [dbo].[tbMotivo] CHECK CONSTRAINT [FK_dbo.tbMotivo_dbo.tbTipoAtendimento_IdTipoAtendimento]
GO
ALTER TABLE [dbo].[tbSetor]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbSetor_dbo.tbSetor_IdSetorPai] FOREIGN KEY([IdSetorPai])
REFERENCES [dbo].[tbSetor] ([IdSetor])
GO
ALTER TABLE [dbo].[tbSetor] CHECK CONSTRAINT [FK_dbo.tbSetor_dbo.tbSetor_IdSetorPai]
GO
ALTER TABLE [dbo].[tbUsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbUsuarioPerfil_dbo.tbPerfil_IdPerfil] FOREIGN KEY([IdPerfil])
REFERENCES [dbo].[tbPerfil] ([IdPerfil])
GO
ALTER TABLE [dbo].[tbUsuarioPerfil] CHECK CONSTRAINT [FK_dbo.tbUsuarioPerfil_dbo.tbPerfil_IdPerfil]
GO
ALTER TABLE [dbo].[tbUsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbUsuarioPerfil_dbo.tbUsuario_IdUsuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbUsuarioPerfil] CHECK CONSTRAINT [FK_dbo.tbUsuarioPerfil_dbo.tbUsuario_IdUsuario]
GO
ALTER TABLE [dbo].[tbUsuarioSetor]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbUsuarioSetor_dbo.tbSetor_IdSetor] FOREIGN KEY([IdSetor])
REFERENCES [dbo].[tbSetor] ([IdSetor])
GO
ALTER TABLE [dbo].[tbUsuarioSetor] CHECK CONSTRAINT [FK_dbo.tbUsuarioSetor_dbo.tbSetor_IdSetor]
GO
ALTER TABLE [dbo].[tbUsuarioSetor]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbUsuarioSetor_dbo.tbUsuario_IdUsuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[tbUsuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[tbUsuarioSetor] CHECK CONSTRAINT [FK_dbo.tbUsuarioSetor_dbo.tbUsuario_IdUsuario]
GO
