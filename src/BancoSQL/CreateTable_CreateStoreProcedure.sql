USE [Banco]
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Descricao varchar (60) = null  
		@Detalhe varchar (30) = null  
		@Unidade varchar (20) = null  
		@CodigoGrupo int = null  
		@EstoqueDisponivel int = null  
		@VendasMes int = null  
		@PrecoVenda float = null  
		@CustoReposicao float = null  
		@DataUltimaCompra datetime = null  
		@DataUltimaVenda datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''ItemEstoque'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@Descricao varchar (60) = null , 
@Detalhe varchar (30) = null , 
@Unidade varchar (20) = null , 
@CodigoGrupo int = null , 
@EstoqueDisponivel int = null , 
@VendasMes int = null , 
@PrecoVenda float = null , 
@CustoReposicao float = null , 
@DataUltimaCompra datetime = null , 
@DataUltimaVenda datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[ItemEstoque]( [CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Descricao),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Detalhe),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Unidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoGrupo),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@EstoqueDisponivel),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@VendasMes),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@PrecoVenda),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CustoReposicao),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataUltimaCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataUltimaVenda),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_DeleteByField]    Script Date: 11/23/2009 00:19:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''ItemEstoque''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[ItemEstoque] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectByField]    Script Date: 11/23/2009 00:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''ItemEstoque'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda] FROM [dbo].[ItemEstoque] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  Table [dbo].[FormaPagamento]    Script Date: 11/23/2009 00:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FormaPagamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FormaPagamento](
	[CodigoFormaPagamento] [int] IDENTITY(1,1) NOT NULL,
	[FormaPagamento] [varchar](50) NULL,
 CONSTRAINT [PK_FormaPagamento] PRIMARY KEY CLUSTERED 
(
	[CodigoFormaPagamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int = null  
		@CodigoItemEstoque int = null  
		@ValorItem float = null  
		@Quantidade int = null  
		@Valor float = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''ItensVendas'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_Insert_WithDefaultValues]
@CodigoVenda int = null , 
@CodigoItemEstoque int = null , 
@ValorItem float = null , 
@Quantidade int = null , 
@Valor float = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[ItensVendas]( [CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoVenda),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorItem),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Quantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int = null  
		@CodigoItemEstoque int = null  
		@ValorItem float = null  
		@Quantidade int = null  
		@Valor float = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''ItensVendas'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_Insert_WithDefaultValues_AndReturn]
@CodigoVenda int = null , 
@CodigoItemEstoque int = null , 
@ValorItem float = null , 
@Quantidade int = null , 
@Valor float = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[ItensVendas]( [CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoVenda),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorItem),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Quantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_DeleteByField]    Script Date: 11/23/2009 00:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''ItensVendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[ItensVendas] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_SelectByField]    Script Date: 11/23/2009 00:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''ItensVendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor] FROM [dbo].[ItensVendas] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupCompra'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[MarkupCompra]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupCompra'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[MarkupCompra]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_DeleteByField]    Script Date: 11/23/2009 00:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''MarkupCompra''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[MarkupCompra] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_SelectByField]    Script Date: 11/23/2009 00:20:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''MarkupCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] FROM [dbo].[MarkupCompra] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupDiferenca'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[MarkupDiferenca]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupDiferenca'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[MarkupDiferenca]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 11/23/2009 00:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Grupo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Grupo](
	[CodigoGrupo] [int] NOT NULL,
	[Grupo] [varchar](60) NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[CodigoGrupo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_DeleteByField]    Script Date: 11/23/2009 00:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''MarkupDiferenca''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[MarkupDiferenca] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_SelectByField]    Script Date: 11/23/2009 00:20:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''MarkupDiferenca'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] FROM [dbo].[MarkupDiferenca] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupVenda'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[MarkupVenda]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupVenda'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[MarkupVenda]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JaneiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@FevereiroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MarcoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AbrilValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@MaioValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JunhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@JulhoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@AgostoValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@SetembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@OutubroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NovembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroQuantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DezembroValor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_DeleteByField]    Script Date: 11/23/2009 00:20:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''MarkupVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[MarkupVenda] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_SelectByField]    Script Date: 11/23/2009 00:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''MarkupVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] FROM [dbo].[MarkupVenda] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int = null  
		@CodigoCliente int = null  
		@NumeroDaParcela int = null  
		@Valor float = null  
		@Juros float = null  
		@ValorPagar float = null  
		@DataDoPagamento datetime = null  
		@DataDoVencimento datetime = null  
		@DiferencaDosDias int = null  
		@Pago varchar (3) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''PagamentoVenda'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_Insert_WithDefaultValues]
@CodigoVenda int = null , 
@CodigoCliente int = null , 
@NumeroDaParcela int = null , 
@Valor float = null , 
@Juros float = null , 
@ValorPagar float = null , 
@DataDoPagamento datetime = null , 
@DataDoVencimento datetime = null , 
@DiferencaDosDias int = null , 
@Pago varchar (3) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[PagamentoVenda]( [CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoVenda),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoCliente),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NumeroDaParcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Juros),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorPagar),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataDoPagamento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataDoVencimento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DiferencaDosDias),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Pago),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int = null  
		@CodigoCliente int = null  
		@NumeroDaParcela int = null  
		@Valor float = null  
		@Juros float = null  
		@ValorPagar float = null  
		@DataDoPagamento datetime = null  
		@DataDoVencimento datetime = null  
		@DiferencaDosDias int = null  
		@Pago varchar (3) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''PagamentoVenda'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_Insert_WithDefaultValues_AndReturn]
@CodigoVenda int = null , 
@CodigoCliente int = null , 
@NumeroDaParcela int = null , 
@Valor float = null , 
@Juros float = null , 
@ValorPagar float = null , 
@DataDoPagamento datetime = null , 
@DataDoVencimento datetime = null , 
@DiferencaDosDias int = null , 
@Pago varchar (3) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[PagamentoVenda]( [CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoVenda),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoCliente),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@NumeroDaParcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Juros),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorPagar),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataDoPagamento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataDoVencimento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DiferencaDosDias),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Pago),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_SelectByField]    Script Date: 11/23/2009 00:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''PagamentoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago] FROM [dbo].[PagamentoVenda] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_DeleteByField]    Script Date: 11/23/2009 00:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''PagamentoVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[PagamentoVenda] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 11/23/2009 00:20:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cidade]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cidade](
	[CodigoCidade] [int] IDENTITY(1,1) NOT NULL,
	[Cidade] [varchar](50) NULL,
	[CEP] [varchar](10) NULL,
	[UF] [varchar](2) NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[CodigoCidade] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int = null  
		@TipoPagamento varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''TipoPagamento'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_Insert_WithDefaultValues]
@CodigoTipoPagamento int = null , 
@TipoPagamento varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[TipoPagamento]( [TipoPagamento] )
VALUES ( '''''' +   isnull(convert(varchar(max),@TipoPagamento),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int = null  
		@TipoPagamento varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''TipoPagamento'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_Insert_WithDefaultValues_AndReturn]
@CodigoTipoPagamento int = null , 
@TipoPagamento varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[TipoPagamento]( [TipoPagamento] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@TipoPagamento),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/23/2009 00:21:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuarios](
	[CodigoUsuario] [int] NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Senha] [varchar](20) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vendedor]    Script Date: 11/23/2009 00:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vendedor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Vendedor](
	[CodigoVendedor] [int] IDENTITY(1,1) NOT NULL,
	[Vendedor] [varchar](30) NULL,
	[DataAdmissao] [smalldatetime] NULL,
	[DataDemissao] [smalldatetime] NULL,
 CONSTRAINT [PK_Vendedor] PRIMARY KEY CLUSTERED 
(
	[CodigoVendedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_DeleteByField]    Script Date: 11/23/2009 00:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''TipoPagamento''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[TipoPagamento] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int = null  
		@Cidade varchar (50) = null  
		@Cep varchar (10) = null  
		@UF varchar (2) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Cidade'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_Insert_WithDefaultValues]
@CodigoCidade int = null , 
@Cidade varchar (50) = null , 
@Cep varchar (10) = null , 
@UF varchar (2) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Cidade]( [Cidade],[CEP],[UF] )
VALUES ( '''''' +   isnull(convert(varchar(max),@Cidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Cep),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@UF),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int = null  
		@Cidade varchar (50) = null  
		@Cep varchar (10) = null  
		@UF varchar (2) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Cidade'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_Insert_WithDefaultValues_AndReturn]
@CodigoCidade int = null , 
@Cidade varchar (50) = null , 
@Cep varchar (10) = null , 
@UF varchar (2) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Cidade]( [Cidade],[CEP],[UF] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@Cidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Cep),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@UF),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_SelectByField]    Script Date: 11/23/2009 00:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''TipoPagamento'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoTipoPagamento],[TipoPagamento] FROM [dbo].[TipoPagamento] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_DeleteByField]    Script Date: 11/23/2009 00:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''Cidade''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[Cidade] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoUsuario int = null  
		@Usuario varchar (50) = null  
		@Senha varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Usuarios'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_Insert_WithDefaultValues_AndReturn]
@CodigoUsuario int = null , 
@Usuario varchar (50) = null , 
@Senha varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Usuarios]( [CodigoUsuario],[Usuario],[Senha] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoUsuario),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Usuario),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Senha),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_SelectByField]    Script Date: 11/23/2009 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''Cidade'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoCidade],[Cidade],[CEP],[UF] FROM [dbo].[Cidade] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoUsuario int = null  
		@Usuario varchar (50) = null  
		@Senha varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Usuarios'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_Insert_WithDefaultValues]
@CodigoUsuario int = null , 
@Usuario varchar (50) = null , 
@Senha varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Usuarios]( [CodigoUsuario],[Usuario],[Senha] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoUsuario),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Usuario),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Senha),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_DeleteByField]    Script Date: 11/23/2009 00:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''Usuarios''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[Usuarios] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int = null  
		@Nome varchar (50) = null  
		@Endereco varchar (50) = null  
		@Bairro varchar (30) = null  
		@Complemento varchar (30) = null  
		@CodigoCidade int = null  
		@RG varchar (15) = null  
		@Cpf varchar (15) = null  
		@Telefone varchar (15) = null  
		@Fax varchar (15) = null  
		@ValorMaiorCompra float = null  
		@TitulosAbertoSPC int = null  
		@IndicePontualidade int = null  
		@DataCadastro datetime = null  
		@DataUltimaCompra datetime = null  
		@DataNascimento datetime = null  
		@Obs text = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Cliente'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_Insert_WithDefaultValues]
@CodigoCliente int = null , 
@Nome varchar (50) = null , 
@Endereco varchar (50) = null , 
@Bairro varchar (30) = null , 
@Complemento varchar (30) = null , 
@CodigoCidade int = null , 
@RG varchar (15) = null , 
@Cpf varchar (15) = null , 
@Telefone varchar (15) = null , 
@Fax varchar (15) = null , 
@ValorMaiorCompra float = null , 
@TitulosAbertoSPC int = null , 
@IndicePontualidade int = null , 
@DataCadastro datetime = null , 
@DataUltimaCompra datetime = null , 
@DataNascimento datetime = null , 
@Obs text = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Cliente]( [Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs] )
VALUES ( '''''' +   isnull(convert(varchar(max),@Nome),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Endereco),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Bairro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Complemento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoCidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@RG),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Cpf),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Telefone),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Fax),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorMaiorCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@TitulosAbertoSPC),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@IndicePontualidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataCadastro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataUltimaCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataNascimento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Obs),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int = null  
		@Nome varchar (50) = null  
		@Endereco varchar (50) = null  
		@Bairro varchar (30) = null  
		@Complemento varchar (30) = null  
		@CodigoCidade int = null  
		@RG varchar (15) = null  
		@Cpf varchar (15) = null  
		@Telefone varchar (15) = null  
		@Fax varchar (15) = null  
		@ValorMaiorCompra float = null  
		@TitulosAbertoSPC int = null  
		@IndicePontualidade int = null  
		@DataCadastro datetime = null  
		@DataUltimaCompra datetime = null  
		@DataNascimento datetime = null  
		@Obs text = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Cliente'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_Insert_WithDefaultValues_AndReturn]
@CodigoCliente int = null , 
@Nome varchar (50) = null , 
@Endereco varchar (50) = null , 
@Bairro varchar (30) = null , 
@Complemento varchar (30) = null , 
@CodigoCidade int = null , 
@RG varchar (15) = null , 
@Cpf varchar (15) = null , 
@Telefone varchar (15) = null , 
@Fax varchar (15) = null , 
@ValorMaiorCompra float = null , 
@TitulosAbertoSPC int = null , 
@IndicePontualidade int = null , 
@DataCadastro datetime = null , 
@DataUltimaCompra datetime = null , 
@DataNascimento datetime = null , 
@Obs text = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Cliente]( [Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@Nome),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Endereco),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Bairro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Complemento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoCidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@RG),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Cpf),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Telefone),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Fax),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorMaiorCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@TitulosAbertoSPC),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@IndicePontualidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataCadastro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataUltimaCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataNascimento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Obs),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_SelectByField]    Script Date: 11/23/2009 00:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''Usuarios'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoUsuario],[Usuario],[Senha] FROM [dbo].[Usuarios] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_DeleteByField]    Script Date: 11/23/2009 00:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''Cliente''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[Cliente] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int = null  
		@CodigoCliente int = null  
		@CodigoVendedor int = null  
		@CodigoTipoPagamento int = null  
		@CodigoFormaPagamento int = null  
		@ValorCompra float = null  
		@ValorDesconto float = null  
		@ValorLiquido float = null  
		@ValorEntrada float = null  
		@QtdeParcela int = null  
		@Valor1Parcela float = null  
		@Data1Parcela datetime = null  
		@Valor2Parcela float = null  
		@Data2Parcela datetime = null  
		@Valor3Parcela float = null  
		@Data3Parcela datetime = null  
		@Valor4Parcela float = null  
		@Data4Parcela datetime = null  
		@Valor5Parcela float = null  
		@Data5Parcela datetime = null  
		@Valor6Parcela float = null  
		@Data6Parcela datetime = null  
		@DataVenda varchar (10) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Vendas'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_Insert_WithDefaultValues]
@CodigoVenda int = null , 
@CodigoCliente int = null , 
@CodigoVendedor int = null , 
@CodigoTipoPagamento int = null , 
@CodigoFormaPagamento int = null , 
@ValorCompra float = null , 
@ValorDesconto float = null , 
@ValorLiquido float = null , 
@ValorEntrada float = null , 
@QtdeParcela int = null , 
@Valor1Parcela float = null , 
@Data1Parcela datetime = null , 
@Valor2Parcela float = null , 
@Data2Parcela datetime = null , 
@Valor3Parcela float = null , 
@Data3Parcela datetime = null , 
@Valor4Parcela float = null , 
@Data4Parcela datetime = null , 
@Valor5Parcela float = null , 
@Data5Parcela datetime = null , 
@Valor6Parcela float = null , 
@Data6Parcela datetime = null , 
@DataVenda varchar (10) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Vendas]( [CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoCliente),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoVendedor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoTipoPagamento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoFormaPagamento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorDesconto),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorLiquido),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorEntrada),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@QtdeParcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor1Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data1Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor2Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data2Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor3Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data3Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor4Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data4Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor5Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data5Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor6Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data6Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataVenda),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int = null  
		@CodigoCliente int = null  
		@CodigoVendedor int = null  
		@CodigoTipoPagamento int = null  
		@CodigoFormaPagamento int = null  
		@ValorCompra float = null  
		@ValorDesconto float = null  
		@ValorLiquido float = null  
		@ValorEntrada float = null  
		@QtdeParcela int = null  
		@Valor1Parcela float = null  
		@Data1Parcela datetime = null  
		@Valor2Parcela float = null  
		@Data2Parcela datetime = null  
		@Valor3Parcela float = null  
		@Data3Parcela datetime = null  
		@Valor4Parcela float = null  
		@Data4Parcela datetime = null  
		@Valor5Parcela float = null  
		@Data5Parcela datetime = null  
		@Valor6Parcela float = null  
		@Data6Parcela datetime = null  
		@DataVenda varchar (10) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Vendas'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_Insert_WithDefaultValues_AndReturn]
@CodigoVenda int = null , 
@CodigoCliente int = null , 
@CodigoVendedor int = null , 
@CodigoTipoPagamento int = null , 
@CodigoFormaPagamento int = null , 
@ValorCompra float = null , 
@ValorDesconto float = null , 
@ValorLiquido float = null , 
@ValorEntrada float = null , 
@QtdeParcela int = null , 
@Valor1Parcela float = null , 
@Data1Parcela datetime = null , 
@Valor2Parcela float = null , 
@Data2Parcela datetime = null , 
@Valor3Parcela float = null , 
@Data3Parcela datetime = null , 
@Valor4Parcela float = null , 
@Data4Parcela datetime = null , 
@Valor5Parcela float = null , 
@Data5Parcela datetime = null , 
@Valor6Parcela float = null , 
@Data6Parcela datetime = null , 
@DataVenda varchar (10) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Vendas]( [CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoCliente),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoVendedor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoTipoPagamento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoFormaPagamento),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorDesconto),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorLiquido),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@ValorEntrada),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@QtdeParcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor1Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data1Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor2Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data2Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor3Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data3Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor4Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data4Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor5Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data5Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor6Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Data6Parcela),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataVenda),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectByField]    Script Date: 11/23/2009 00:19:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''Cliente'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoCliente],[Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs] FROM [dbo].[Cliente] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_DeleteByField]    Script Date: 11/23/2009 00:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''Vendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[Vendas] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectByField]    Script Date: 11/23/2009 00:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda] FROM [dbo].[Vendas] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoFormaPagamento int = null  
		@FormaPagamento varchar (50) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''FormaPagamento'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_Insert_WithDefaultValues]
@CodigoFormaPagamento int = null , 
@FormaPagamento varchar (50) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[FormaPagamento]( [FormaPagamento] )
VALUES ( '''''' +   isnull(convert(varchar(max),@FormaPagamento),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoFormaPagamento int = null  
		@FormaPagamento varchar (50) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''FormaPagamento'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_Insert_WithDefaultValues_AndReturn]
@CodigoFormaPagamento int = null , 
@FormaPagamento varchar (50) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[FormaPagamento]( [FormaPagamento] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@FormaPagamento),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_DeleteByField]    Script Date: 11/23/2009 00:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''FormaPagamento''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[FormaPagamento] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_SelectByField]    Script Date: 11/23/2009 00:19:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''FormaPagamento'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoFormaPagamento],[FormaPagamento] FROM [dbo].[FormaPagamento] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Janeiro int = null  
		@Fevereio int = null  
		@Marco int = null  
		@Abril int = null  
		@Maio int = null  
		@Junho int = null  
		@Julho int = null  
		@Agosto int = null  
		@Setembro int = null  
		@Outubro int = null  
		@Novembro int = null  
		@Dezembro int = null  
		@Ano datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''VendasMes'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@Janeiro int = null , 
@Fevereio int = null , 
@Marco int = null , 
@Abril int = null , 
@Maio int = null , 
@Junho int = null , 
@Julho int = null , 
@Agosto int = null , 
@Setembro int = null , 
@Outubro int = null , 
@Novembro int = null , 
@Dezembro int = null , 
@Ano datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[VendasMes]( [CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Janeiro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Fevereio),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Marco),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Abril),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Maio),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Junho),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Julho),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Agosto),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Setembro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Outubro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Novembro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Dezembro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Janeiro int = null  
		@Fevereio int = null  
		@Marco int = null  
		@Abril int = null  
		@Maio int = null  
		@Junho int = null  
		@Julho int = null  
		@Agosto int = null  
		@Setembro int = null  
		@Outubro int = null  
		@Novembro int = null  
		@Dezembro int = null  
		@Ano datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''VendasMes'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@Janeiro int = null , 
@Fevereio int = null , 
@Marco int = null , 
@Abril int = null , 
@Maio int = null , 
@Junho int = null , 
@Julho int = null , 
@Agosto int = null , 
@Setembro int = null , 
@Outubro int = null , 
@Novembro int = null , 
@Dezembro int = null , 
@Ano datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[VendasMes]( [CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Janeiro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Fevereio),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Marco),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Abril),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Maio),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Junho),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Julho),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Agosto),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Setembro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Outubro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Novembro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Dezembro),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Ano),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int = null  
		@Grupo varchar (60) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Grupo'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_Insert_WithDefaultValues]
@CodigoGrupo int = null , 
@Grupo varchar (60) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Grupo]( [CodigoGrupo],[Grupo] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoGrupo),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Grupo),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int = null  
		@Grupo varchar (60) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Grupo'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_Insert_WithDefaultValues_AndReturn]
@CodigoGrupo int = null , 
@Grupo varchar (60) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Grupo]( [CodigoGrupo],[Grupo] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoGrupo),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Grupo),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_DeleteByField]    Script Date: 11/23/2009 00:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''VendasMes''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[VendasMes] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_DeleteByField]    Script Date: 11/23/2009 00:19:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''Grupo''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[Grupo] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_SelectByField]    Script Date: 11/23/2009 00:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''VendasMes'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano] FROM [dbo].[VendasMes] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_SelectByField]    Script Date: 11/23/2009 00:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''Grupo'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoGrupo],[Grupo] FROM [dbo].[Grupo] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:20:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoVendedor int = null  
		@Vendedor varchar (30) = null  
		@DataAdmissao datetime = null  
		@DataDemissao datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Vendedor'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_Insert_WithDefaultValues]
@CodigoVendedor int = null , 
@Vendedor varchar (30) = null , 
@DataAdmissao datetime = null , 
@DataDemissao datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Vendedor]( [Vendedor],[DataAdmissao],[DataDemissao] )
VALUES ( '''''' +   isnull(convert(varchar(max),@Vendedor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataAdmissao),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataDemissao),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:20:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoVendedor int = null  
		@Vendedor varchar (30) = null  
		@DataAdmissao datetime = null  
		@DataDemissao datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Vendedor'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_Insert_WithDefaultValues_AndReturn]
@CodigoVendedor int = null , 
@Vendedor varchar (30) = null , 
@DataAdmissao datetime = null , 
@DataDemissao datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[Vendedor]( [Vendedor],[DataAdmissao],[DataDemissao] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@Vendedor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataAdmissao),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataDemissao),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Quantidade int = null  
		@Valor float = null  
		@DataCompra datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''HistoricoCompra'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@Quantidade int = null , 
@Valor float = null , 
@DataCompra datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[HistoricoCompra]( [CodigoItemEstoque],[Quantidade],[Valor],[DataCompra] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Quantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataCompra),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  Table [dbo].[TipoPagamento]    Script Date: 11/23/2009 00:21:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoPagamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoPagamento](
	[CodigoTipoPagamento] [int] IDENTITY(1,1) NOT NULL,
	[TipoPagamento] [varchar](20) NULL,
 CONSTRAINT [PK_CondicaoPagamento] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoPagamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Quantidade int = null  
		@Valor float = null  
		@DataCompra datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''HistoricoCompra'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@Quantidade int = null , 
@Valor float = null , 
@DataCompra datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[HistoricoCompra]( [CodigoItemEstoque],[Quantidade],[Valor],[DataCompra] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Quantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataCompra),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_DeleteByField]    Script Date: 11/23/2009 00:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''Vendedor''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[Vendedor] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_DeleteByField]    Script Date: 11/23/2009 00:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''HistoricoCompra''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[HistoricoCompra] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_SelectByField]    Script Date: 11/23/2009 00:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''Vendedor'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoVendedor],[Vendedor],[DataAdmissao],[DataDemissao] FROM [dbo].[Vendedor] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_SelectByField]    Script Date: 11/23/2009 00:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''HistoricoCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[Quantidade],[Valor],[DataCompra] FROM [dbo].[HistoricoCompra] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_DeleteByField]    Script Date: 11/23/2009 00:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_DeleteByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_DeleteByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete row(s) from the table ''HistoricoVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_DeleteByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- DELETE row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''DELETE FROM [dbo].[HistoricoVenda] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Quantidade int = null  
		@Valor float = null  
		@DataVenda datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''HistoricoVenda'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@Quantidade int = null , 
@Valor float = null , 
@DataVenda datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[HistoricoVenda]( [CodigoItemEstoque],[Quantidade],[Valor],[DataVenda] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Quantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataVenda),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_Insert_WithDefaultValues_AndReturn]    Script Date: 11/23/2009 00:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_Insert_WithDefaultValues_AndReturn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_Insert_WithDefaultValues_AndReturn
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Quantidade int = null  
		@Valor float = null  
		@DataVenda datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''HistoricoVenda'' and return back the entire row
(with the default values inserted)
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_Insert_WithDefaultValues_AndReturn]
@CodigoItemEstoque int = null , 
@Quantidade int = null , 
@Valor float = null , 
@DataVenda datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table

DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[HistoricoVenda]( [CodigoItemEstoque],[Quantidade],[Valor],[DataVenda] )
OUTPUT Inserted.*
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Quantidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Valor),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataVenda),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_SelectByField]    Script Date: 11/23/2009 00:19:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_SelectByField]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_SelectByField
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Field varchar(100)
		@Value varchar(1000)

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select row(s) from the table ''HistoricoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_SelectByField]
@Field varchar(100),
@Value varchar(1000),
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT row(s) from the table
DECLARE @query varchar(2000)

SET @query = ''SELECT [CodigoItemEstoque],[Quantidade],[Valor],[DataVenda] FROM [dbo].[HistoricoVenda] WHERE ['' + @Field + ''] = '''''' + @Value + ''''''''
EXEC(@query)


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_Insert_WithDefaultValues]    Script Date: 11/23/2009 00:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_Insert_WithDefaultValues]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_Insert_WithDefaultValues
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int = null  
		@Descricao varchar (60) = null  
		@Detalhe varchar (30) = null  
		@Unidade varchar (20) = null  
		@CodigoGrupo int = null  
		@EstoqueDisponivel int = null  
		@VendasMes int = null  
		@PrecoVenda float = null  
		@CustoReposicao float = null  
		@DataUltimaCompra datetime = null  
		@DataUltimaVenda datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''ItemEstoque'' using the default values
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_Insert_WithDefaultValues]
@CodigoItemEstoque int = null , 
@Descricao varchar (60) = null , 
@Detalhe varchar (30) = null , 
@Unidade varchar (20) = null , 
@CodigoGrupo int = null , 
@EstoqueDisponivel int = null , 
@VendasMes int = null , 
@PrecoVenda float = null , 
@CustoReposicao float = null , 
@DataUltimaCompra datetime = null , 
@DataUltimaVenda datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
DECLARE @strSqlStatment nvarchar(4000)
set @strSqlStatment  = ''               
INSERT INTO [dbo].[ItemEstoque]( [CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda] )
VALUES ( '''''' +   isnull(convert(varchar(max),@CodigoItemEstoque),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Descricao),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Detalhe),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@Unidade),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CodigoGrupo),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@EstoqueDisponivel),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@VendasMes),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@PrecoVenda),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@CustoReposicao),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataUltimaCompra),''Default'') + '''''', '''''' +isnull(convert(varchar(max),@DataUltimaVenda),''Default'')  +'''''')'' ; 

select @strSqlStatment = replace ( @strSqlStatment , ''''''Default'''''' , ''Default'' )

execute (@strSqlStatment)

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 11/23/2009 00:21:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Vendas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Vendas](
	[CodigoVenda] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCliente] [int] NULL,
	[CodigoVendedor] [int] NULL,
	[CodigoTipoPagamento] [int] NULL,
	[CodigoFormaPagamento] [int] NULL,
	[ValorCompra] [decimal](10, 2) NULL,
	[ValorDesconto] [decimal](10, 2) NULL,
	[ValorLiquido] [decimal](10, 2) NULL,
	[ValorEntrada] [decimal](10, 2) NULL,
	[QtdeParcela] [int] NULL,
	[Valor1Parcela] [decimal](10, 2) NULL,
	[Data1Parcela] [smalldatetime] NULL,
	[Valor2Parcela] [decimal](10, 2) NULL,
	[Data2Parcela] [smalldatetime] NULL,
	[Valor3Parcela] [decimal](10, 2) NULL,
	[Data3Parcela] [smalldatetime] NULL,
	[Valor4Parcela] [decimal](10, 2) NULL,
	[Data4Parcela] [smalldatetime] NULL,
	[Valor5Parcela] [decimal](10, 2) NULL,
	[Data5Parcela] [smalldatetime] NULL,
	[Valor6Parcela] [decimal](10, 2) NULL,
	[Data6Parcela] [smalldatetime] NULL,
	[DataVenda] [nvarchar](10) NULL,
 CONSTRAINT [PK_MovimentacaoVendas] PRIMARY KEY CLUSTERED 
(
	[CodigoVenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ItemEstoque]    Script Date: 11/23/2009 00:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemEstoque]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemEstoque](
	[CodigoItemEstoque] [int] NOT NULL,
	[Descricao] [varchar](60) NULL,
	[Detalhe] [varchar](30) NULL,
	[Unidade] [varchar](20) NULL,
	[CodigoGrupo] [int] NULL,
	[EstoqueDisponivel] [int] NULL,
	[VendasMes] [int] NULL,
	[PrecoVenda] [decimal](10, 2) NULL,
	[CustoReposicao] [decimal](10, 2) NULL,
	[DataUltimaCompra] [smalldatetime] NULL,
	[DataUltimaVenda] [smalldatetime] NULL,
 CONSTRAINT [PK_ItemEstoque] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/23/2009 00:21:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cliente](
	[CodigoCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Bairro] [varchar](30) NULL,
	[Complemento] [varchar](30) NULL,
	[CodigoCidade] [int] NULL,
	[RG] [varchar](15) NULL,
	[CPF] [varchar](15) NULL,
	[Telefone] [varchar](15) NULL,
	[Fax] [varchar](15) NULL,
	[ValorMaiorCompra] [decimal](10, 2) NULL,
	[TitulosAbertoSPC] [int] NULL,
	[IndicePontualidade] [int] NULL,
	[DataCadastro] [smalldatetime] NULL,
	[DataUltimaCompra] [smalldatetime] NULL,
	[DataNascimento] [smalldatetime] NULL,
	[Obs] [varchar](max) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[CodigoCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagamentoVenda]    Script Date: 11/23/2009 00:21:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PagamentoVenda]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PagamentoVenda](
	[CodigoVenda] [int] NOT NULL,
	[CodigoCliente] [int] NOT NULL,
	[NumeroDaParcela] [int] NOT NULL,
	[Valor] [decimal](10, 2) NULL,
	[Juros] [decimal](10, 2) NULL,
	[ValorPagar] [decimal](10, 2) NULL,
	[DataDoPagamento] [smalldatetime] NULL,
	[DataDoVencimento] [smalldatetime] NULL,
	[DiferencaDosDias] [int] NULL,
	[Pago] [char](3) NULL,
 CONSTRAINT [PK_PagamentoVenda_1] PRIMARY KEY CLUSTERED 
(
	[CodigoVenda] ASC,
	[CodigoCliente] ASC,
	[NumeroDaParcela] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItensVendas]    Script Date: 11/23/2009 00:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItensVendas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItensVendas](
	[CodigoVenda] [int] NOT NULL,
	[CodigoItemEstoque] [int] NOT NULL,
	[ValorItem] [decimal](10, 2) NULL,
	[Quantidade] [int] NULL,
	[Valor] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ItensVendas_1] PRIMARY KEY CLUSTERED 
(
	[CodigoVenda] ASC,
	[CodigoItemEstoque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[VendasMes]    Script Date: 11/23/2009 00:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VendasMes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VendasMes](
	[CodigoItemEstoque] [int] NOT NULL,
	[Janeiro] [int] NULL,
	[Fevereio] [int] NULL,
	[Marco] [int] NULL,
	[Abril] [int] NULL,
	[Maio] [int] NULL,
	[Junho] [int] NULL,
	[Julho] [int] NULL,
	[Agosto] [int] NULL,
	[Setembro] [int] NULL,
	[Outubro] [int] NULL,
	[Novembro] [int] NULL,
	[Dezembro] [int] NULL,
	[Ano] [smalldatetime] NULL,
 CONSTRAINT [PK_VendasMes] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[HistoricoVenda]    Script Date: 11/23/2009 00:21:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoricoVenda]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HistoricoVenda](
	[CodigoItemEstoque] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
	[DataVenda] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_HistoricoVenda] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC,
	[Quantidade] ASC,
	[Valor] ASC,
	[DataVenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MarkupVenda]    Script Date: 11/23/2009 00:21:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MarkupVenda]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MarkupVenda](
	[CodigoItemEstoque] [int] NOT NULL,
	[JaneiroQuantidade] [int] NULL,
	[JaneiroValor] [decimal](10, 2) NULL,
	[FevereiroQuantidade] [int] NULL,
	[FevereiroValor] [decimal](10, 2) NULL,
	[MarcoQuantidade] [int] NULL,
	[MarcoValor] [decimal](10, 2) NULL,
	[AbrilQuantidade] [int] NULL,
	[AbrilValor] [decimal](10, 2) NULL,
	[MaioQuantidade] [int] NULL,
	[MaioValor] [decimal](10, 2) NULL,
	[JunhoQuantidade] [int] NULL,
	[JunhoValor] [decimal](10, 2) NULL,
	[JulhoQuantidade] [int] NULL,
	[JulhoValor] [decimal](10, 2) NULL,
	[AgostoQuantidade] [int] NULL,
	[AgostoValor] [decimal](10, 2) NULL,
	[SetembroQuantidade] [int] NULL,
	[SetembroValor] [decimal](10, 2) NULL,
	[OutubroQuantidade] [int] NULL,
	[OutubroValor] [decimal](10, 2) NULL,
	[NovembroQuantidade] [int] NULL,
	[NovembroValor] [decimal](10, 2) NULL,
	[DezembroQuantidade] [int] NULL,
	[DezembroValor] [decimal](10, 2) NULL,
	[Ano] [int] NOT NULL,
 CONSTRAINT [PK_MarkupVenda] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC,
	[Ano] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MarkupDiferenca]    Script Date: 11/23/2009 00:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MarkupDiferenca]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MarkupDiferenca](
	[CodigoItemEstoque] [int] NOT NULL,
	[JaneiroQuantidade] [int] NULL,
	[JaneiroValor] [decimal](10, 2) NULL,
	[FevereiroQuantidade] [int] NULL,
	[FevereiroValor] [decimal](10, 2) NULL,
	[MarcoQuantidade] [int] NULL,
	[MarcoValor] [decimal](10, 2) NULL,
	[AbrilQuantidade] [int] NULL,
	[AbrilValor] [decimal](10, 2) NULL,
	[MaioQuantidade] [int] NULL,
	[MaioValor] [decimal](10, 2) NULL,
	[JunhoQuantidade] [int] NULL,
	[JunhoValor] [decimal](10, 2) NULL,
	[JulhoQuantidade] [int] NULL,
	[JulhoValor] [decimal](10, 2) NULL,
	[AgostoQuantidade] [int] NULL,
	[AgostoValor] [decimal](10, 2) NULL,
	[SetembroQuantidade] [int] NULL,
	[SetembroValor] [decimal](10, 2) NULL,
	[OutubroQuantidade] [int] NULL,
	[OutubroValor] [decimal](10, 2) NULL,
	[NovembroQuantidade] [int] NULL,
	[NovembroValor] [decimal](10, 2) NULL,
	[DezembroQuantidade] [int] NULL,
	[DezembroValor] [decimal](10, 2) NULL,
	[Ano] [int] NOT NULL,
 CONSTRAINT [PK_MarkupDiferenca] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC,
	[Ano] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MarkupCompra]    Script Date: 11/23/2009 00:21:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MarkupCompra]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MarkupCompra](
	[CodigoItemEstoque] [int] NOT NULL,
	[JaneiroQuantidade] [int] NULL,
	[JaneiroValor] [decimal](10, 2) NULL,
	[FevereiroQuantidade] [int] NULL,
	[FevereiroValor] [decimal](10, 2) NULL,
	[MarcoQuantidade] [int] NULL,
	[MarcoValor] [decimal](10, 2) NULL,
	[AbrilQuantidade] [int] NULL,
	[AbrilValor] [decimal](10, 2) NULL,
	[MaioQuantidade] [int] NULL,
	[MaioValor] [decimal](10, 2) NULL,
	[JunhoQuantidade] [int] NULL,
	[JunhoValor] [decimal](10, 2) NULL,
	[JulhoQuantidade] [int] NULL,
	[JulhoValor] [decimal](10, 2) NULL,
	[AgostoQuantidade] [int] NULL,
	[AgostoValor] [decimal](10, 2) NULL,
	[SetembroQuantidade] [int] NULL,
	[SetembroValor] [decimal](10, 2) NULL,
	[OutubroQuantidade] [int] NULL,
	[OutubroValor] [decimal](10, 2) NULL,
	[NovembroQuantidade] [int] NULL,
	[NovembroValor] [decimal](10, 2) NULL,
	[DezembroQuantidade] [int] NULL,
	[DezembroValor] [decimal](10, 2) NULL,
	[Ano] [int] NOT NULL,
 CONSTRAINT [PK_MarkupCompra] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC,
	[Ano] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[HistoricoCompra]    Script Date: 11/23/2009 00:21:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoricoCompra]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HistoricoCompra](
	[CodigoItemEstoque] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
	[DataCompra] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_HistoricoCompra] PRIMARY KEY CLUSTERED 
(
	[CodigoItemEstoque] ASC,
	[Quantidade] ASC,
	[Valor] ASC,
	[DataCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_Insert]    Script Date: 11/23/2009 00:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoCliente int  
		@NumeroDaParcela int  
		@Valor float = null  
		@Juros float = null  
		@ValorPagar float = null  
		@DataDoPagamento datetime = null  
		@DataDoVencimento datetime = null  
		@DiferencaDosDias int = null  
		@Pago varchar (3) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''PagamentoVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_Insert]
@CodigoVenda int , 
@CodigoCliente int , 
@NumeroDaParcela int , 
@Valor float = null , 
@Juros float = null , 
@ValorPagar float = null , 
@DataDoPagamento datetime = null , 
@DataDoVencimento datetime = null , 
@DiferencaDosDias int = null , 
@Pago varchar (3) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[PagamentoVenda]( [CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago] )
VALUES ( @CodigoVenda,@CodigoCliente,@NumeroDaParcela,@Valor,@Juros,@ValorPagar,@DataDoPagamento,@DataDoVencimento,@DiferencaDosDias,@Pago )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 
		@CodigoCliente int 
		@NumeroDaParcela int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''PagamentoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_SelectByPrimaryKey]
@CodigoVenda int ,
@CodigoCliente int ,
@NumeroDaParcela int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago]
FROM	[dbo].[PagamentoVenda]
WHERE
	[CodigoVenda] = @CodigoVenda
AND [CodigoCliente] = @CodigoCliente
AND [NumeroDaParcela] = @NumeroDaParcela


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_SelectAll]    Script Date: 11/23/2009 00:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''PagamentoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago]
FROM	[dbo].[PagamentoVenda]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_SelectAllByForeignKeyCliente]    Script Date: 11/23/2009 00:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_SelectAllByForeignKeyCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_SelectAllByForeignKeyCliente
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoCliente int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''PagamentoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_SelectAllByForeignKeyCliente]
@CodigoCliente int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago]
FROM	[dbo].[PagamentoVenda]
WHERE
	[CodigoCliente] = @CodigoCliente


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_SelectAllByForeignKeyVendas]    Script Date: 11/23/2009 00:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_SelectAllByForeignKeyVendas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_SelectAllByForeignKeyVendas
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''PagamentoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_SelectAllByForeignKeyVendas]
@CodigoVenda int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[NumeroDaParcela],[Valor],[Juros],[ValorPagar],[DataDoPagamento],[DataDoVencimento],[DiferencaDosDias],[Pago]
FROM	[dbo].[PagamentoVenda]
WHERE
	[CodigoVenda] = @CodigoVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_Update]    Script Date: 11/23/2009 00:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoCliente int  
		@NumeroDaParcela int  
		@Valor float = null  
		@Juros float = null  
		@ValorPagar float = null  
		@DataDoPagamento datetime = null  
		@DataDoVencimento datetime = null  
		@DiferencaDosDias int = null  
		@Pago varchar (3) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''PagamentoVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_Update]
@CodigoVenda int , 
@CodigoCliente int , 
@NumeroDaParcela int , 
@Valor float = null , 
@Juros float = null , 
@ValorPagar float = null , 
@DataDoPagamento datetime = null , 
@DataDoVencimento datetime = null , 
@DiferencaDosDias int = null , 
@Pago varchar (3) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[PagamentoVenda]
SET
	[Valor] = @Valor ,
	[Juros] = @Juros ,
	[ValorPagar] = @ValorPagar ,
	[DataDoPagamento] = @DataDoPagamento ,
	[DataDoVencimento] = @DataDoVencimento ,
	[DiferencaDosDias] = @DiferencaDosDias ,
	[Pago] = @Pago
WHERE
[CodigoVenda] = @CodigoVenda
AND [CodigoCliente] = @CodigoCliente
AND [NumeroDaParcela] = @NumeroDaParcela


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PagamentoVenda_Delete]    Script Date: 11/23/2009 00:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_PagamentoVenda_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_PagamentoVenda_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoCliente int  
		@NumeroDaParcela int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''PagamentoVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_PagamentoVenda_Delete]
@CodigoVenda int , 
@CodigoCliente int , 
@NumeroDaParcela int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[PagamentoVenda]
WHERE
[CodigoVenda] = @CodigoVenda
AND [CodigoCliente] = @CodigoCliente
AND [NumeroDaParcela] = @NumeroDaParcela


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoFormaPagamento int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''FormaPagamento'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_SelectByPrimaryKey]
@CodigoFormaPagamento int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoFormaPagamento],[FormaPagamento]
FROM	[dbo].[FormaPagamento]
WHERE
	[CodigoFormaPagamento] = @CodigoFormaPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_Update]    Script Date: 11/23/2009 00:19:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoFormaPagamento int  
		@FormaPagamento varchar (50) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''FormaPagamento'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_Update]
@CodigoFormaPagamento int , 
@FormaPagamento varchar (50) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[FormaPagamento]
SET
	[FormaPagamento] = @FormaPagamento
WHERE
[CodigoFormaPagamento] = @CodigoFormaPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_Delete]    Script Date: 11/23/2009 00:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoFormaPagamento int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''FormaPagamento'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_Delete]
@CodigoFormaPagamento int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[FormaPagamento]
WHERE
[CodigoFormaPagamento] = @CodigoFormaPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_Insert]    Script Date: 11/23/2009 00:19:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@FormaPagamento varchar (50) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''FormaPagamento'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_Insert]
@FormaPagamento varchar (50) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[FormaPagamento]( [FormaPagamento] )
VALUES ( @FormaPagamento )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_SelectAll]    Script Date: 11/23/2009 00:19:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''FormaPagamento'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoFormaPagamento],[FormaPagamento]
FROM	[dbo].[FormaPagamento]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_Insert]    Script Date: 11/23/2009 00:20:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int  
		@Janeiro int = null  
		@Fevereio int = null  
		@Marco int = null  
		@Abril int = null  
		@Maio int = null  
		@Junho int = null  
		@Julho int = null  
		@Agosto int = null  
		@Setembro int = null  
		@Outubro int = null  
		@Novembro int = null  
		@Dezembro int = null  
		@Ano datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''VendasMes'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_Insert]
@CodigoItemEstoque int , 
@Janeiro int = null , 
@Fevereio int = null , 
@Marco int = null , 
@Abril int = null , 
@Maio int = null , 
@Junho int = null , 
@Julho int = null , 
@Agosto int = null , 
@Setembro int = null , 
@Outubro int = null , 
@Novembro int = null , 
@Dezembro int = null , 
@Ano datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[VendasMes]( [CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano] )
VALUES ( @CodigoItemEstoque,@Janeiro,@Fevereio,@Marco,@Abril,@Maio,@Junho,@Julho,@Agosto,@Setembro,@Outubro,@Novembro,@Dezembro,@Ano )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_Delete]    Script Date: 11/23/2009 00:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''VendasMes'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_Delete]
@CodigoItemEstoque int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[VendasMes]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_Update]    Script Date: 11/23/2009 00:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int  
		@Janeiro int = null  
		@Fevereio int = null  
		@Marco int = null  
		@Abril int = null  
		@Maio int = null  
		@Junho int = null  
		@Julho int = null  
		@Agosto int = null  
		@Setembro int = null  
		@Outubro int = null  
		@Novembro int = null  
		@Dezembro int = null  
		@Ano datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''VendasMes'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_Update]
@CodigoItemEstoque int , 
@Janeiro int = null , 
@Fevereio int = null , 
@Marco int = null , 
@Abril int = null , 
@Maio int = null , 
@Junho int = null , 
@Julho int = null , 
@Agosto int = null , 
@Setembro int = null , 
@Outubro int = null , 
@Novembro int = null , 
@Dezembro int = null , 
@Ano datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[VendasMes]
SET
	[Janeiro] = @Janeiro ,
	[Fevereio] = @Fevereio ,
	[Marco] = @Marco ,
	[Abril] = @Abril ,
	[Maio] = @Maio ,
	[Junho] = @Junho ,
	[Julho] = @Julho ,
	[Agosto] = @Agosto ,
	[Setembro] = @Setembro ,
	[Outubro] = @Outubro ,
	[Novembro] = @Novembro ,
	[Dezembro] = @Dezembro ,
	[Ano] = @Ano
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_SelectAll]    Script Date: 11/23/2009 00:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''VendasMes'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano]
FROM	[dbo].[VendasMes]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''VendasMes'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano]
FROM	[dbo].[VendasMes]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_VendasMes_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_VendasMes_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_VendasMes_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''VendasMes'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_VendasMes_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Janeiro],[Fevereio],[Marco],[Abril],[Maio],[Junho],[Julho],[Agosto],[Setembro],[Outubro],[Novembro],[Dezembro],[Ano]
FROM	[dbo].[VendasMes]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''MarkupCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupCompra]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_Insert]    Script Date: 11/23/2009 00:20:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupCompra'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_Insert]
@CodigoItemEstoque int , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[MarkupCompra]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
VALUES ( @CodigoItemEstoque,@JaneiroQuantidade,@JaneiroValor,@FevereiroQuantidade,@FevereiroValor,@MarcoQuantidade,@MarcoValor,@AbrilQuantidade,@AbrilValor,@MaioQuantidade,@MaioValor,@JunhoQuantidade,@JunhoValor,@JulhoQuantidade,@JulhoValor,@AgostoQuantidade,@AgostoValor,@SetembroQuantidade,@SetembroValor,@OutubroQuantidade,@OutubroValor,@NovembroQuantidade,@NovembroValor,@DezembroQuantidade,@DezembroValor,@Ano )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		@Ano int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''MarkupCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@Ano int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupCompra]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_SelectAll]    Script Date: 11/23/2009 00:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''MarkupCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupCompra]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_Update]    Script Date: 11/23/2009 00:20:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''MarkupCompra'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_Update]
@CodigoItemEstoque int , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[MarkupCompra]
SET
	[JaneiroQuantidade] = @JaneiroQuantidade ,
	[JaneiroValor] = @JaneiroValor ,
	[FevereiroQuantidade] = @FevereiroQuantidade ,
	[FevereiroValor] = @FevereiroValor ,
	[MarcoQuantidade] = @MarcoQuantidade ,
	[MarcoValor] = @MarcoValor ,
	[AbrilQuantidade] = @AbrilQuantidade ,
	[AbrilValor] = @AbrilValor ,
	[MaioQuantidade] = @MaioQuantidade ,
	[MaioValor] = @MaioValor ,
	[JunhoQuantidade] = @JunhoQuantidade ,
	[JunhoValor] = @JunhoValor ,
	[JulhoQuantidade] = @JulhoQuantidade ,
	[JulhoValor] = @JulhoValor ,
	[AgostoQuantidade] = @AgostoQuantidade ,
	[AgostoValor] = @AgostoValor ,
	[SetembroQuantidade] = @SetembroQuantidade ,
	[SetembroValor] = @SetembroValor ,
	[OutubroQuantidade] = @OutubroQuantidade ,
	[OutubroValor] = @OutubroValor ,
	[NovembroQuantidade] = @NovembroQuantidade ,
	[NovembroValor] = @NovembroValor ,
	[DezembroQuantidade] = @DezembroQuantidade ,
	[DezembroValor] = @DezembroValor
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupCompra_Delete]    Script Date: 11/23/2009 00:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupCompra_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupCompra_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''MarkupCompra'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupCompra_Delete]
@CodigoItemEstoque int , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[MarkupCompra]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sysdiagrams_Insert]    Script Date: 11/23/2009 00:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sysdiagrams_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_sysdiagrams_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@Name varchar (128)  
		@PrincipalID int  
		@Version int = null  
		@Definition image = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''sysdiagrams'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_sysdiagrams_Insert]
@Name varchar (128) , 
@PrincipalID int , 
@Version int = null , 
@Definition image = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[sysdiagrams]( [name],[principal_id],[version],[definition] )
VALUES ( @Name,@PrincipalID,@Version,@Definition )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_SelectAll]    Script Date: 11/23/2009 00:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''Grupo'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoGrupo],[Grupo]
FROM	[dbo].[Grupo]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_Delete]    Script Date: 11/23/2009 00:19:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''Grupo'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_Delete]
@CodigoGrupo int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[Grupo]
WHERE
[CodigoGrupo] = @CodigoGrupo


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_Update]    Script Date: 11/23/2009 00:19:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int  
		@Grupo varchar (60) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''Grupo'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_Update]
@CodigoGrupo int , 
@Grupo varchar (60) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[Grupo]
SET
	[Grupo] = @Grupo
WHERE
[CodigoGrupo] = @CodigoGrupo


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Grupo'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_SelectByPrimaryKey]
@CodigoGrupo int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoGrupo],[Grupo]
FROM	[dbo].[Grupo]
WHERE
	[CodigoGrupo] = @CodigoGrupo


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_Insert]    Script Date: 11/23/2009 00:19:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int  
		@Grupo varchar (60) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Grupo'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_Insert]
@CodigoGrupo int , 
@Grupo varchar (60) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[Grupo]( [CodigoGrupo],[Grupo] )
VALUES ( @CodigoGrupo,@Grupo )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_Insert]    Script Date: 11/23/2009 00:20:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_Insert]
@CodigoItemEstoque int , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[MarkupVenda]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
VALUES ( @CodigoItemEstoque,@JaneiroQuantidade,@JaneiroValor,@FevereiroQuantidade,@FevereiroValor,@MarcoQuantidade,@MarcoValor,@AbrilQuantidade,@AbrilValor,@MaioQuantidade,@MaioValor,@JunhoQuantidade,@JunhoValor,@JulhoQuantidade,@JulhoValor,@AgostoQuantidade,@AgostoValor,@SetembroQuantidade,@SetembroValor,@OutubroQuantidade,@OutubroValor,@NovembroQuantidade,@NovembroValor,@DezembroQuantidade,@DezembroValor,@Ano )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''MarkupVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupVenda]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		@Ano int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''MarkupVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@Ano int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupVenda]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_SelectAll]    Script Date: 11/23/2009 00:20:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''MarkupVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupVenda]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_Update]    Script Date: 11/23/2009 00:20:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''MarkupVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_Update]
@CodigoItemEstoque int , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[MarkupVenda]
SET
	[JaneiroQuantidade] = @JaneiroQuantidade ,
	[JaneiroValor] = @JaneiroValor ,
	[FevereiroQuantidade] = @FevereiroQuantidade ,
	[FevereiroValor] = @FevereiroValor ,
	[MarcoQuantidade] = @MarcoQuantidade ,
	[MarcoValor] = @MarcoValor ,
	[AbrilQuantidade] = @AbrilQuantidade ,
	[AbrilValor] = @AbrilValor ,
	[MaioQuantidade] = @MaioQuantidade ,
	[MaioValor] = @MaioValor ,
	[JunhoQuantidade] = @JunhoQuantidade ,
	[JunhoValor] = @JunhoValor ,
	[JulhoQuantidade] = @JulhoQuantidade ,
	[JulhoValor] = @JulhoValor ,
	[AgostoQuantidade] = @AgostoQuantidade ,
	[AgostoValor] = @AgostoValor ,
	[SetembroQuantidade] = @SetembroQuantidade ,
	[SetembroValor] = @SetembroValor ,
	[OutubroQuantidade] = @OutubroQuantidade ,
	[OutubroValor] = @OutubroValor ,
	[NovembroQuantidade] = @NovembroQuantidade ,
	[NovembroValor] = @NovembroValor ,
	[DezembroQuantidade] = @DezembroQuantidade ,
	[DezembroValor] = @DezembroValor
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupVenda_Delete]    Script Date: 11/23/2009 00:20:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupVenda_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupVenda_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''MarkupVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupVenda_Delete]
@CodigoItemEstoque int , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[MarkupVenda]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:20:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''MarkupDiferenca'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupDiferenca]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		@Ano int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''MarkupDiferenca'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@Ano int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupDiferenca]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_SelectAll]    Script Date: 11/23/2009 00:20:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''MarkupDiferenca'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano]
FROM	[dbo].[MarkupDiferenca]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_Insert]    Script Date: 11/23/2009 00:20:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''MarkupDiferenca'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_Insert]
@CodigoItemEstoque int , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[MarkupDiferenca]( [CodigoItemEstoque],[JaneiroQuantidade],[JaneiroValor],[FevereiroQuantidade],[FevereiroValor],[MarcoQuantidade],[MarcoValor],[AbrilQuantidade],[AbrilValor],[MaioQuantidade],[MaioValor],[JunhoQuantidade],[JunhoValor],[JulhoQuantidade],[JulhoValor],[AgostoQuantidade],[AgostoValor],[SetembroQuantidade],[SetembroValor],[OutubroQuantidade],[OutubroValor],[NovembroQuantidade],[NovembroValor],[DezembroQuantidade],[DezembroValor],[Ano] )
VALUES ( @CodigoItemEstoque,@JaneiroQuantidade,@JaneiroValor,@FevereiroQuantidade,@FevereiroValor,@MarcoQuantidade,@MarcoValor,@AbrilQuantidade,@AbrilValor,@MaioQuantidade,@MaioValor,@JunhoQuantidade,@JunhoValor,@JulhoQuantidade,@JulhoValor,@AgostoQuantidade,@AgostoValor,@SetembroQuantidade,@SetembroValor,@OutubroQuantidade,@OutubroValor,@NovembroQuantidade,@NovembroValor,@DezembroQuantidade,@DezembroValor,@Ano )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_Update]    Script Date: 11/23/2009 00:20:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@JaneiroQuantidade int = null  
		@JaneiroValor float = null  
		@FevereiroQuantidade int = null  
		@FevereiroValor float = null  
		@MarcoQuantidade int = null  
		@MarcoValor float = null  
		@AbrilQuantidade int = null  
		@AbrilValor float = null  
		@MaioQuantidade int = null  
		@MaioValor float = null  
		@JunhoQuantidade int = null  
		@JunhoValor float = null  
		@JulhoQuantidade int = null  
		@JulhoValor float = null  
		@AgostoQuantidade int = null  
		@AgostoValor float = null  
		@SetembroQuantidade int = null  
		@SetembroValor float = null  
		@OutubroQuantidade int = null  
		@OutubroValor float = null  
		@NovembroQuantidade int = null  
		@NovembroValor float = null  
		@DezembroQuantidade int = null  
		@DezembroValor float = null  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''MarkupDiferenca'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_Update]
@CodigoItemEstoque int , 
@JaneiroQuantidade int = null , 
@JaneiroValor float = null , 
@FevereiroQuantidade int = null , 
@FevereiroValor float = null , 
@MarcoQuantidade int = null , 
@MarcoValor float = null , 
@AbrilQuantidade int = null , 
@AbrilValor float = null , 
@MaioQuantidade int = null , 
@MaioValor float = null , 
@JunhoQuantidade int = null , 
@JunhoValor float = null , 
@JulhoQuantidade int = null , 
@JulhoValor float = null , 
@AgostoQuantidade int = null , 
@AgostoValor float = null , 
@SetembroQuantidade int = null , 
@SetembroValor float = null , 
@OutubroQuantidade int = null , 
@OutubroValor float = null , 
@NovembroQuantidade int = null , 
@NovembroValor float = null , 
@DezembroQuantidade int = null , 
@DezembroValor float = null , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[MarkupDiferenca]
SET
	[JaneiroQuantidade] = @JaneiroQuantidade ,
	[JaneiroValor] = @JaneiroValor ,
	[FevereiroQuantidade] = @FevereiroQuantidade ,
	[FevereiroValor] = @FevereiroValor ,
	[MarcoQuantidade] = @MarcoQuantidade ,
	[MarcoValor] = @MarcoValor ,
	[AbrilQuantidade] = @AbrilQuantidade ,
	[AbrilValor] = @AbrilValor ,
	[MaioQuantidade] = @MaioQuantidade ,
	[MaioValor] = @MaioValor ,
	[JunhoQuantidade] = @JunhoQuantidade ,
	[JunhoValor] = @JunhoValor ,
	[JulhoQuantidade] = @JulhoQuantidade ,
	[JulhoValor] = @JulhoValor ,
	[AgostoQuantidade] = @AgostoQuantidade ,
	[AgostoValor] = @AgostoValor ,
	[SetembroQuantidade] = @SetembroQuantidade ,
	[SetembroValor] = @SetembroValor ,
	[OutubroQuantidade] = @OutubroQuantidade ,
	[OutubroValor] = @OutubroValor ,
	[NovembroQuantidade] = @NovembroQuantidade ,
	[NovembroValor] = @NovembroValor ,
	[DezembroQuantidade] = @DezembroQuantidade ,
	[DezembroValor] = @DezembroValor
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MarkupDiferenca_Delete]    Script Date: 11/23/2009 00:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_MarkupDiferenca_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_MarkupDiferenca_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Ano int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''MarkupDiferenca'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_MarkupDiferenca_Delete]
@CodigoItemEstoque int , 
@Ano int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[MarkupDiferenca]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Ano] = @Ano


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_Delete]    Script Date: 11/23/2009 00:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Quantidade int  
		@Valor float  
		@DataVenda datetime  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''HistoricoVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_Delete]
@CodigoItemEstoque int , 
@Quantidade int , 
@Valor float , 
@DataVenda datetime , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[HistoricoVenda]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Quantidade] = @Quantidade
AND [Valor] = @Valor
AND [DataVenda] = @DataVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:19:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''HistoricoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Quantidade],[Valor],[DataVenda]
FROM	[dbo].[HistoricoVenda]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		@Quantidade int 
		@Valor float 
		@DataVenda datetime 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''HistoricoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@Quantidade int ,
@Valor float ,
@DataVenda datetime ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Quantidade],[Valor],[DataVenda]
FROM	[dbo].[HistoricoVenda]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque
AND [Quantidade] = @Quantidade
AND [Valor] = @Valor
AND [DataVenda] = @DataVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_SelectAll]    Script Date: 11/23/2009 00:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''HistoricoVenda'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[Quantidade],[Valor],[DataVenda]
FROM	[dbo].[HistoricoVenda]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoVenda_Insert]    Script Date: 11/23/2009 00:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoVenda_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoVenda_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Quantidade int  
		@Valor float  
		@DataVenda datetime  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''HistoricoVenda'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoVenda_Insert]
@CodigoItemEstoque int , 
@Quantidade int , 
@Valor float , 
@DataVenda datetime , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[HistoricoVenda]( [CodigoItemEstoque],[Quantidade],[Valor],[DataVenda] )
VALUES ( @CodigoItemEstoque,@Quantidade,@Valor,@DataVenda )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_Insert]    Script Date: 11/23/2009 00:19:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Cidade varchar (50) = null  
		@Cep varchar (10) = null  
		@UF varchar (2) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Cidade'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_Insert]
@Cidade varchar (50) = null , 
@Cep varchar (10) = null , 
@UF varchar (2) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[Cidade]( [Cidade],[CEP],[UF] )
VALUES ( @Cidade,@Cep,@UF )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_SelectAll]    Script Date: 11/23/2009 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''Cidade'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoCidade],[Cidade],[CEP],[UF]
FROM	[dbo].[Cidade]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_Update]    Script Date: 11/23/2009 00:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int  
		@Cidade varchar (50) = null  
		@Cep varchar (10) = null  
		@UF varchar (2) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''Cidade'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_Update]
@CodigoCidade int , 
@Cidade varchar (50) = null , 
@Cep varchar (10) = null , 
@UF varchar (2) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[Cidade]
SET
	[Cidade] = @Cidade ,
	[CEP] = @Cep ,
	[UF] = @UF
WHERE
[CodigoCidade] = @CodigoCidade


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Cidade'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_SelectByPrimaryKey]
@CodigoCidade int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoCidade],[Cidade],[CEP],[UF]
FROM	[dbo].[Cidade]
WHERE
	[CodigoCidade] = @CodigoCidade


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_Delete]    Script Date: 11/23/2009 00:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''Cidade'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_Delete]
@CodigoCidade int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[Cidade]
WHERE
[CodigoCidade] = @CodigoCidade


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''HistoricoCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Quantidade],[Valor],[DataCompra]
FROM	[dbo].[HistoricoCompra]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_SelectAll]    Script Date: 11/23/2009 00:19:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''HistoricoCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[Quantidade],[Valor],[DataCompra]
FROM	[dbo].[HistoricoCompra]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_Insert]    Script Date: 11/23/2009 00:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoItemEstoque int  
		@Quantidade int  
		@Valor float  
		@DataCompra datetime  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''HistoricoCompra'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_Insert]
@CodigoItemEstoque int , 
@Quantidade int , 
@Valor float , 
@DataCompra datetime , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[HistoricoCompra]( [CodigoItemEstoque],[Quantidade],[Valor],[DataCompra] )
VALUES ( @CodigoItemEstoque,@Quantidade,@Valor,@DataCompra )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoItemEstoque int 
		@Quantidade int 
		@Valor float 
		@DataCompra datetime 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''HistoricoCompra'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@Quantidade int ,
@Valor float ,
@DataCompra datetime ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Quantidade],[Valor],[DataCompra]
FROM	[dbo].[HistoricoCompra]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque
AND [Quantidade] = @Quantidade
AND [Valor] = @Valor
AND [DataCompra] = @DataCompra


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HistoricoCompra_Delete]    Script Date: 11/23/2009 00:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_HistoricoCompra_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_HistoricoCompra_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoItemEstoque int  
		@Quantidade int  
		@Valor float  
		@DataCompra datetime  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''HistoricoCompra'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_HistoricoCompra_Delete]
@CodigoItemEstoque int , 
@Quantidade int , 
@Valor float , 
@DataCompra datetime , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[HistoricoCompra]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque
AND [Quantidade] = @Quantidade
AND [Valor] = @Valor
AND [DataCompra] = @DataCompra


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_Insert]    Script Date: 11/23/2009 00:20:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoUsuario int  
		@Usuario varchar (50) = null  
		@Senha varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Usuarios'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_Insert]
@CodigoUsuario int , 
@Usuario varchar (50) = null , 
@Senha varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[Usuarios]( [CodigoUsuario],[Usuario],[Senha] )
VALUES ( @CodigoUsuario,@Usuario,@Senha )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_Delete]    Script Date: 11/23/2009 00:20:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoUsuario int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''Usuarios'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_Delete]
@CodigoUsuario int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[Usuarios]
WHERE
[CodigoUsuario] = @CodigoUsuario


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_Update]    Script Date: 11/23/2009 00:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoUsuario int  
		@Usuario varchar (50) = null  
		@Senha varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''Usuarios'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_Update]
@CodigoUsuario int , 
@Usuario varchar (50) = null , 
@Senha varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[Usuarios]
SET
	[Usuario] = @Usuario ,
	[Senha] = @Senha
WHERE
[CodigoUsuario] = @CodigoUsuario


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_SelectAll]    Script Date: 11/23/2009 00:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''Usuarios'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoUsuario],[Usuario],[Senha]
FROM	[dbo].[Usuarios]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Usuarios_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Usuarios_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoUsuario int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Usuarios'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Usuarios_SelectByPrimaryKey]
@CodigoUsuario int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoUsuario],[Usuario],[Senha]
FROM	[dbo].[Usuarios]
WHERE
	[CodigoUsuario] = @CodigoUsuario


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoVendedor int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendedor'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_SelectByPrimaryKey]
@CodigoVendedor int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVendedor],[Vendedor],[DataAdmissao],[DataDemissao]
FROM	[dbo].[Vendedor]
WHERE
	[CodigoVendedor] = @CodigoVendedor


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_SelectAll]    Script Date: 11/23/2009 00:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''Vendedor'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoVendedor],[Vendedor],[DataAdmissao],[DataDemissao]
FROM	[dbo].[Vendedor]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_Update]    Script Date: 11/23/2009 00:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoVendedor int  
		@Vendedor varchar (30) = null  
		@DataAdmissao datetime = null  
		@DataDemissao datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''Vendedor'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_Update]
@CodigoVendedor int , 
@Vendedor varchar (30) = null , 
@DataAdmissao datetime = null , 
@DataDemissao datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[Vendedor]
SET
	[Vendedor] = @Vendedor ,
	[DataAdmissao] = @DataAdmissao ,
	[DataDemissao] = @DataDemissao
WHERE
[CodigoVendedor] = @CodigoVendedor


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_Delete]    Script Date: 11/23/2009 00:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoVendedor int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''Vendedor'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_Delete]
@CodigoVendedor int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[Vendedor]
WHERE
[CodigoVendedor] = @CodigoVendedor


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_Insert]    Script Date: 11/23/2009 00:20:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@Vendedor varchar (30) = null  
		@DataAdmissao datetime = null  
		@DataDemissao datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Vendedor'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_Insert]
@Vendedor varchar (30) = null , 
@DataAdmissao datetime = null , 
@DataDemissao datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[Vendedor]( [Vendedor],[DataAdmissao],[DataDemissao] )
VALUES ( @Vendedor,@DataAdmissao,@DataDemissao )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuery]    Script Date: 11/23/2009 00:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateQuery]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateQuery]
(
	@Nome varchar(50),
	@Endereco varchar(50),
	@Bairro varchar(30),
	@Complemento varchar(30),
	@CodigoCidade int,
	@RG varchar(15),
	@CPF varchar(15),
	@Telefone varchar(15),
	@Fax varchar(15),
	@ValorMaiorCompra decimal(10, 2),
	@TitulosAbertoSPC int,
	@IndicePontualidade int,
	@DataCadastro smalldatetime,
	@DataUltimaCompra smalldatetime,
	@DataNascimento smalldatetime,
	@Obs varchar(MAX),
	@Original_CodigoCliente int,
	@IsNull_Nome Int,
	@Original_Nome varchar(50),
	@IsNull_Endereco Int,
	@Original_Endereco varchar(50),
	@IsNull_Bairro Int,
	@Original_Bairro varchar(30),
	@IsNull_Complemento Int,
	@Original_Complemento varchar(30),
	@IsNull_CodigoCidade Int,
	@Original_CodigoCidade int,
	@IsNull_RG Int,
	@Original_RG varchar(15),
	@IsNull_CPF Int,
	@Original_CPF varchar(15),
	@IsNull_Telefone Int,
	@Original_Telefone varchar(15),
	@IsNull_Fax Int,
	@Original_Fax varchar(15),
	@IsNull_ValorMaiorCompra Int,
	@Original_ValorMaiorCompra decimal(10, 2),
	@IsNull_TitulosAbertoSPC Int,
	@Original_TitulosAbertoSPC int,
	@IsNull_IndicePontualidade Int,
	@Original_IndicePontualidade int,
	@IsNull_DataCadastro Int,
	@Original_DataCadastro smalldatetime,
	@IsNull_DataUltimaCompra Int,
	@Original_DataUltimaCompra smalldatetime,
	@IsNull_DataNascimento Int,
	@Original_DataNascimento smalldatetime
)
AS
	SET NOCOUNT OFF;
UPDATE [Cliente] SET [Nome] = @Nome, [Endereco] = @Endereco, [Bairro] = @Bairro, [Complemento] = @Complemento, [CodigoCidade] = @CodigoCidade, [RG] = @RG, [CPF] = @CPF, [Telefone] = @Telefone, [Fax] = @Fax, [ValorMaiorCompra] = @ValorMaiorCompra, [TitulosAbertoSPC] = @TitulosAbertoSPC, [IndicePontualidade] = @IndicePontualidade, [DataCadastro] = @DataCadastro, [DataUltimaCompra] = @DataUltimaCompra, [DataNascimento] = @DataNascimento, [Obs] = @Obs WHERE (([CodigoCliente] = @Original_CodigoCliente) AND ((@IsNull_Nome = 1 AND [Nome] IS NULL) OR ([Nome] = @Original_Nome)) AND ((@IsNull_Endereco = 1 AND [Endereco] IS NULL) OR ([Endereco] = @Original_Endereco)) AND ((@IsNull_Bairro = 1 AND [Bairro] IS NULL) OR ([Bairro] = @Original_Bairro)) AND ((@IsNull_Complemento = 1 AND [Complemento] IS NULL) OR ([Complemento] = @Original_Complemento)) AND ((@IsNull_CodigoCidade = 1 AND [CodigoCidade] IS NULL) OR ([CodigoCidade] = @Original_CodigoCidade)) AND ((@IsNull_RG = 1 AND [RG] IS NULL) OR ([RG] = @Original_RG)) AND ((@IsNull_CPF = 1 AND [CPF] IS NULL) OR ([CPF] = @Original_CPF)) AND ((@IsNull_Telefone = 1 AND [Telefone] IS NULL) OR ([Telefone] = @Original_Telefone)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_ValorMaiorCompra = 1 AND [ValorMaiorCompra] IS NULL) OR ([ValorMaiorCompra] = @Original_ValorMaiorCompra)) AND ((@IsNull_TitulosAbertoSPC = 1 AND [TitulosAbertoSPC] IS NULL) OR ([TitulosAbertoSPC] = @Original_TitulosAbertoSPC)) AND ((@IsNull_IndicePontualidade = 1 AND [IndicePontualidade] IS NULL) OR ([IndicePontualidade] = @Original_IndicePontualidade)) AND ((@IsNull_DataCadastro = 1 AND [DataCadastro] IS NULL) OR ([DataCadastro] = @Original_DataCadastro)) AND ((@IsNull_DataUltimaCompra = 1 AND [DataUltimaCompra] IS NULL) OR ([DataUltimaCompra] = @Original_DataUltimaCompra)) AND ((@IsNull_DataNascimento = 1 AND [DataNascimento] IS NULL) OR ([DataNascimento] = @Original_DataNascimento)));
	
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_Update]    Script Date: 11/23/2009 00:19:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int  
		@Nome varchar (50) = null  
		@Endereco varchar (50) = null  
		@Bairro varchar (30) = null  
		@Complemento varchar (30) = null  
		@CodigoCidade int = null  
		@RG varchar (15) = null  
		@Cpf varchar (15) = null  
		@Telefone varchar (15) = null  
		@Fax varchar (15) = null  
		@ValorMaiorCompra float = null  
		@TitulosAbertoSPC int = null  
		@IndicePontualidade int = null  
		@DataCadastro datetime = null  
		@DataUltimaCompra datetime = null  
		@DataNascimento datetime = null  
		@Obs text = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''Cliente'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_Update]
@CodigoCliente int , 
@Nome varchar (50) = null , 
@Endereco varchar (50) = null , 
@Bairro varchar (30) = null , 
@Complemento varchar (30) = null , 
@CodigoCidade int = null , 
@RG varchar (15) = null , 
@Cpf varchar (15) = null , 
@Telefone varchar (15) = null , 
@Fax varchar (15) = null , 
@ValorMaiorCompra float = null , 
@TitulosAbertoSPC int = null , 
@IndicePontualidade int = null , 
@DataCadastro datetime = null , 
@DataUltimaCompra datetime = null , 
@DataNascimento datetime = null , 
@Obs text = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[Cliente]
SET
	[Nome] = @Nome ,
	[Endereco] = @Endereco ,
	[Bairro] = @Bairro ,
	[Complemento] = @Complemento ,
	[CodigoCidade] = @CodigoCidade ,
	[RG] = @RG ,
	[CPF] = @Cpf ,
	[Telefone] = @Telefone ,
	[Fax] = @Fax ,
	[ValorMaiorCompra] = @ValorMaiorCompra ,
	[TitulosAbertoSPC] = @TitulosAbertoSPC ,
	[IndicePontualidade] = @IndicePontualidade ,
	[DataCadastro] = @DataCadastro ,
	[DataUltimaCompra] = @DataUltimaCompra ,
	[DataNascimento] = @DataNascimento ,
	[Obs] = @Obs
WHERE
[CodigoCliente] = @CodigoCliente


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Cliente'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_SelectByPrimaryKey]
@CodigoCliente int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoCliente],[Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs]
FROM	[dbo].[Cliente]
WHERE
	[CodigoCliente] = @CodigoCliente


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_Delete]    Script Date: 11/23/2009 00:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''Cliente'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_Delete]
@CodigoCliente int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[Cliente]
WHERE
[CodigoCliente] = @CodigoCliente


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectAllByForeignKeyCidade]    Script Date: 11/23/2009 00:19:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_SelectAllByForeignKeyCidade]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_SelectAllByForeignKeyCidade
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Cliente'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_SelectAllByForeignKeyCidade]
@CodigoCidade int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoCliente],[Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs]
FROM	[dbo].[Cliente]
WHERE
	[CodigoCidade] = @CodigoCidade


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectAll]    Script Date: 11/23/2009 00:19:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''Cliente'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoCliente],[Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs]
FROM	[dbo].[Cliente]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_Insert]    Script Date: 11/23/2009 00:19:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@Nome varchar (50) = null  
		@Endereco varchar (50) = null  
		@Bairro varchar (30) = null  
		@Complemento varchar (30) = null  
		@CodigoCidade int = null  
		@RG varchar (15) = null  
		@Cpf varchar (15) = null  
		@Telefone varchar (15) = null  
		@Fax varchar (15) = null  
		@ValorMaiorCompra float = null  
		@TitulosAbertoSPC int = null  
		@IndicePontualidade int = null  
		@DataCadastro datetime = null  
		@DataUltimaCompra datetime = null  
		@DataNascimento datetime = null  
		@Obs text = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Cliente'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_Insert]
@Nome varchar (50) = null , 
@Endereco varchar (50) = null , 
@Bairro varchar (30) = null , 
@Complemento varchar (30) = null , 
@CodigoCidade int = null , 
@RG varchar (15) = null , 
@Cpf varchar (15) = null , 
@Telefone varchar (15) = null , 
@Fax varchar (15) = null , 
@ValorMaiorCompra float = null , 
@TitulosAbertoSPC int = null , 
@IndicePontualidade int = null , 
@DataCadastro datetime = null , 
@DataUltimaCompra datetime = null , 
@DataNascimento datetime = null , 
@Obs text = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[Cliente]( [Nome],[Endereco],[Bairro],[Complemento],[CodigoCidade],[RG],[CPF],[Telefone],[Fax],[ValorMaiorCompra],[TitulosAbertoSPC],[IndicePontualidade],[DataCadastro],[DataUltimaCompra],[DataNascimento],[Obs] )
VALUES ( @Nome,@Endereco,@Bairro,@Complemento,@CodigoCidade,@RG,@Cpf,@Telefone,@Fax,@ValorMaiorCompra,@TitulosAbertoSPC,@IndicePontualidade,@DataCadastro,@DataUltimaCompra,@DataNascimento,@Obs )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_SelectAll]    Script Date: 11/23/2009 00:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''TipoPagamento'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoTipoPagamento],[TipoPagamento]
FROM	[dbo].[TipoPagamento]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_Insert]    Script Date: 11/23/2009 00:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@TipoPagamento varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''TipoPagamento'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_Insert]
@TipoPagamento varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[TipoPagamento]( [TipoPagamento] )
VALUES ( @TipoPagamento )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''TipoPagamento'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_SelectByPrimaryKey]
@CodigoTipoPagamento int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoTipoPagamento],[TipoPagamento]
FROM	[dbo].[TipoPagamento]
WHERE
	[CodigoTipoPagamento] = @CodigoTipoPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_Update]    Script Date: 11/23/2009 00:20:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int  
		@TipoPagamento varchar (20) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''TipoPagamento'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_Update]
@CodigoTipoPagamento int , 
@TipoPagamento varchar (20) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[TipoPagamento]
SET
	[TipoPagamento] = @TipoPagamento
WHERE
[CodigoTipoPagamento] = @CodigoTipoPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_Delete]    Script Date: 11/23/2009 00:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''TipoPagamento'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_Delete]
@CodigoTipoPagamento int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[TipoPagamento]
WHERE
[CodigoTipoPagamento] = @CodigoTipoPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_Update]    Script Date: 11/23/2009 00:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoCliente int = null  
		@CodigoVendedor int = null  
		@CodigoTipoPagamento int = null  
		@CodigoFormaPagamento int = null  
		@ValorCompra float = null  
		@ValorDesconto float = null  
		@ValorLiquido float = null  
		@ValorEntrada float = null  
		@QtdeParcela int = null  
		@Valor1Parcela float = null  
		@Data1Parcela datetime = null  
		@Valor2Parcela float = null  
		@Data2Parcela datetime = null  
		@Valor3Parcela float = null  
		@Data3Parcela datetime = null  
		@Valor4Parcela float = null  
		@Data4Parcela datetime = null  
		@Valor5Parcela float = null  
		@Data5Parcela datetime = null  
		@Valor6Parcela float = null  
		@Data6Parcela datetime = null  
		@DataVenda varchar (10) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''Vendas'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_Update]
@CodigoVenda int , 
@CodigoCliente int = null , 
@CodigoVendedor int = null , 
@CodigoTipoPagamento int = null , 
@CodigoFormaPagamento int = null , 
@ValorCompra float = null , 
@ValorDesconto float = null , 
@ValorLiquido float = null , 
@ValorEntrada float = null , 
@QtdeParcela int = null , 
@Valor1Parcela float = null , 
@Data1Parcela datetime = null , 
@Valor2Parcela float = null , 
@Data2Parcela datetime = null , 
@Valor3Parcela float = null , 
@Data3Parcela datetime = null , 
@Valor4Parcela float = null , 
@Data4Parcela datetime = null , 
@Valor5Parcela float = null , 
@Data5Parcela datetime = null , 
@Valor6Parcela float = null , 
@Data6Parcela datetime = null , 
@DataVenda varchar (10) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[Vendas]
SET
	[CodigoCliente] = @CodigoCliente ,
	[CodigoVendedor] = @CodigoVendedor ,
	[CodigoTipoPagamento] = @CodigoTipoPagamento ,
	[CodigoFormaPagamento] = @CodigoFormaPagamento ,
	[ValorCompra] = @ValorCompra ,
	[ValorDesconto] = @ValorDesconto ,
	[ValorLiquido] = @ValorLiquido ,
	[ValorEntrada] = @ValorEntrada ,
	[QtdeParcela] = @QtdeParcela ,
	[Valor1Parcela] = @Valor1Parcela ,
	[Data1Parcela] = @Data1Parcela ,
	[Valor2Parcela] = @Valor2Parcela ,
	[Data2Parcela] = @Data2Parcela ,
	[Valor3Parcela] = @Valor3Parcela ,
	[Data3Parcela] = @Data3Parcela ,
	[Valor4Parcela] = @Valor4Parcela ,
	[Data4Parcela] = @Data4Parcela ,
	[Valor5Parcela] = @Valor5Parcela ,
	[Data5Parcela] = @Data5Parcela ,
	[Valor6Parcela] = @Valor6Parcela ,
	[Data6Parcela] = @Data6Parcela ,
	[DataVenda] = @DataVenda
WHERE
[CodigoVenda] = @CodigoVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_Delete]    Script Date: 11/23/2009 00:20:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''Vendas'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_Delete]
@CodigoVenda int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[Vendas]
WHERE
[CodigoVenda] = @CodigoVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectAll]    Script Date: 11/23/2009 00:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda]
FROM	[dbo].[Vendas]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_Insert]    Script Date: 11/23/2009 00:20:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoCliente int = null  
		@CodigoVendedor int = null  
		@CodigoTipoPagamento int = null  
		@CodigoFormaPagamento int = null  
		@ValorCompra float = null  
		@ValorDesconto float = null  
		@ValorLiquido float = null  
		@ValorEntrada float = null  
		@QtdeParcela int = null  
		@Valor1Parcela float = null  
		@Data1Parcela datetime = null  
		@Valor2Parcela float = null  
		@Data2Parcela datetime = null  
		@Valor3Parcela float = null  
		@Data3Parcela datetime = null  
		@Valor4Parcela float = null  
		@Data4Parcela datetime = null  
		@Valor5Parcela float = null  
		@Data5Parcela datetime = null  
		@Valor6Parcela float = null  
		@Data6Parcela datetime = null  
		@DataVenda varchar (10) = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''Vendas'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_Insert]
@CodigoCliente int = null , 
@CodigoVendedor int = null , 
@CodigoTipoPagamento int = null , 
@CodigoFormaPagamento int = null , 
@ValorCompra float = null , 
@ValorDesconto float = null , 
@ValorLiquido float = null , 
@ValorEntrada float = null , 
@QtdeParcela int = null , 
@Valor1Parcela float = null , 
@Data1Parcela datetime = null , 
@Valor2Parcela float = null , 
@Data2Parcela datetime = null , 
@Valor3Parcela float = null , 
@Data3Parcela datetime = null , 
@Valor4Parcela float = null , 
@Data4Parcela datetime = null , 
@Valor5Parcela float = null , 
@Data5Parcela datetime = null , 
@Valor6Parcela float = null , 
@Data6Parcela datetime = null , 
@DataVenda varchar (10) = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[Vendas]( [CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda] )
VALUES ( @CodigoCliente,@CodigoVendedor,@CodigoTipoPagamento,@CodigoFormaPagamento,@ValorCompra,@ValorDesconto,@ValorLiquido,@ValorEntrada,@QtdeParcela,@Valor1Parcela,@Data1Parcela,@Valor2Parcela,@Data2Parcela,@Valor3Parcela,@Data3Parcela,@Valor4Parcela,@Data4Parcela,@Valor5Parcela,@Data5Parcela,@Valor6Parcela,@Data6Parcela,@DataVenda )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectByPrimaryKey]
@CodigoVenda int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda]
FROM	[dbo].[Vendas]
WHERE
	[CodigoVenda] = @CodigoVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectAllByForeignKeyFormaPagamento]    Script Date: 11/23/2009 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectAllByForeignKeyFormaPagamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectAllByForeignKeyFormaPagamento
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoFormaPagamento int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectAllByForeignKeyFormaPagamento]
@CodigoFormaPagamento int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda]
FROM	[dbo].[Vendas]
WHERE
	[CodigoFormaPagamento] = @CodigoFormaPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectAllByForeignKeyCliente]    Script Date: 11/23/2009 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectAllByForeignKeyCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectAllByForeignKeyCliente
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoCliente int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectAllByForeignKeyCliente]
@CodigoCliente int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda]
FROM	[dbo].[Vendas]
WHERE
	[CodigoCliente] = @CodigoCliente


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectAllByForeignKeyVendedor]    Script Date: 11/23/2009 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectAllByForeignKeyVendedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectAllByForeignKeyVendedor
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVendedor int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectAllByForeignKeyVendedor]
@CodigoVendedor int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda]
FROM	[dbo].[Vendas]
WHERE
	[CodigoVendedor] = @CodigoVendedor


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectAllByForeignKeyTipoPagamento]    Script Date: 11/23/2009 00:20:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectAllByForeignKeyTipoPagamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectAllByForeignKeyTipoPagamento
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectAllByForeignKeyTipoPagamento]
@CodigoTipoPagamento int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoCliente],[CodigoVendedor],[CodigoTipoPagamento],[CodigoFormaPagamento],[ValorCompra],[ValorDesconto],[ValorLiquido],[ValorEntrada],[QtdeParcela],[Valor1Parcela],[Data1Parcela],[Valor2Parcela],[Data2Parcela],[Valor3Parcela],[Data3Parcela],[Valor4Parcela],[Data4Parcela],[Valor5Parcela],[Data5Parcela],[Valor6Parcela],[Data6Parcela],[DataVenda]
FROM	[dbo].[Vendas]
WHERE
	[CodigoTipoPagamento] = @CodigoTipoPagamento


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectByPrimaryKey]    Script Date: 11/23/2009 00:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectByPrimaryKey]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda]
FROM	[dbo].[ItemEstoque]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectAll]    Script Date: 11/23/2009 00:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''ItemEstoque'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda]
FROM	[dbo].[ItemEstoque]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_Update]    Script Date: 11/23/2009 00:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Descricao varchar (60) = null  
		@Detalhe varchar (30) = null  
		@Unidade varchar (20) = null  
		@CodigoGrupo int = null  
		@EstoqueDisponivel int = null  
		@VendasMes int = null  
		@PrecoVenda float = null  
		@CustoReposicao float = null  
		@DataUltimaCompra datetime = null  
		@DataUltimaVenda datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''ItemEstoque'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_Update]
@CodigoItemEstoque int , 
@Descricao varchar (60) = null , 
@Detalhe varchar (30) = null , 
@Unidade varchar (20) = null , 
@CodigoGrupo int = null , 
@EstoqueDisponivel int = null , 
@VendasMes int = null , 
@PrecoVenda float = null , 
@CustoReposicao float = null , 
@DataUltimaCompra datetime = null , 
@DataUltimaVenda datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[ItemEstoque]
SET
	[Descricao] = @Descricao ,
	[Detalhe] = @Detalhe ,
	[Unidade] = @Unidade ,
	[CodigoGrupo] = @CodigoGrupo ,
	[EstoqueDisponivel] = @EstoqueDisponivel ,
	[VendasMes] = @VendasMes ,
	[PrecoVenda] = @PrecoVenda ,
	[CustoReposicao] = @CustoReposicao ,
	[DataUltimaCompra] = @DataUltimaCompra ,
	[DataUltimaVenda] = @DataUltimaVenda
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_Delete]    Script Date: 11/23/2009 00:19:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''ItemEstoque'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_Delete]
@CodigoItemEstoque int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[ItemEstoque]
WHERE
[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectAllByForeignKeyGrupo]    Script Date: 11/23/2009 00:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectAllByForeignKeyGrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectAllByForeignKeyGrupo
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoGrupo int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectAllByForeignKeyGrupo]
@CodigoGrupo int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda]
FROM	[dbo].[ItemEstoque]
WHERE
	[CodigoGrupo] = @CodigoGrupo


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_Insert]    Script Date: 11/23/2009 00:19:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int  
		@Descricao varchar (60) = null  
		@Detalhe varchar (30) = null  
		@Unidade varchar (20) = null  
		@CodigoGrupo int = null  
		@EstoqueDisponivel int = null  
		@VendasMes int = null  
		@PrecoVenda float = null  
		@CustoReposicao float = null  
		@DataUltimaCompra datetime = null  
		@DataUltimaVenda datetime = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''ItemEstoque'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_Insert]
@CodigoItemEstoque int , 
@Descricao varchar (60) = null , 
@Detalhe varchar (30) = null , 
@Unidade varchar (20) = null , 
@CodigoGrupo int = null , 
@EstoqueDisponivel int = null , 
@VendasMes int = null , 
@PrecoVenda float = null , 
@CustoReposicao float = null , 
@DataUltimaCompra datetime = null , 
@DataUltimaVenda datetime = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[ItemEstoque]( [CodigoItemEstoque],[Descricao],[Detalhe],[Unidade],[CodigoGrupo],[EstoqueDisponivel],[VendasMes],[PrecoVenda],[CustoReposicao],[DataUltimaCompra],[DataUltimaVenda] )
VALUES ( @CodigoItemEstoque,@Descricao,@Detalhe,@Unidade,@CodigoGrupo,@EstoqueDisponivel,@VendasMes,@PrecoVenda,@CustoReposicao,@DataUltimaCompra,@DataUltimaVenda )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_Insert]    Script Date: 11/23/2009 00:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_Insert
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoItemEstoque int  
		@ValorItem float = null  
		@Quantidade int = null  
		@Valor float = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will insert 1 row in the table ''ItensVendas'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_Insert]
@CodigoVenda int , 
@CodigoItemEstoque int , 
@ValorItem float = null , 
@Quantidade int = null , 
@Valor float = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- INSERT a new row in the table
INSERT INTO [dbo].[ItensVendas]( [CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor] )
VALUES ( @CodigoVenda,@CodigoItemEstoque,@ValorItem,@Quantidade,@Valor )

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_SelectAllByForeignKeyItemEstoque]    Script Date: 11/23/2009 00:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_SelectAllByForeignKeyItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_SelectAllByForeignKeyItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItensVendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_SelectAllByForeignKeyItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor]
FROM	[dbo].[ItensVendas]
WHERE
	[CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_SelectAllByForeignKeyVendas]    Script Date: 11/23/2009 00:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_SelectAllByForeignKeyVendas]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_SelectAllByForeignKeyVendas
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItensVendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_SelectAllByForeignKeyVendas]
@CodigoVenda int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor]
FROM	[dbo].[ItensVendas]
WHERE
	[CodigoVenda] = @CodigoVenda


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_SelectByPrimaryKey]    Script Date: 11/23/2009 00:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_SelectByPrimaryKey]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_SelectByPrimaryKey
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItensVendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_SelectByPrimaryKey]
@CodigoVenda int ,
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the table
SELECT	[CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor]
FROM	[dbo].[ItensVendas]
WHERE
	[CodigoVenda] = @CodigoVenda
AND [CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_SelectAll]    Script Date: 11/23/2009 00:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_SelectAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_SelectAll
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select all rows from the table ''ItensVendas'' 
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_SelectAll]
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT all row(s) from the table
SELECT	[CodigoVenda],[CodigoItemEstoque],[ValorItem],[Quantidade],[Valor]
FROM	[dbo].[ItensVendas]


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_Update]    Script Date: 11/23/2009 00:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_Update
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoItemEstoque int  
		@ValorItem float = null  
		@Quantidade int = null  
		@Valor float = null  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will update 1 row in the table ''ItensVendas'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_Update]
@CodigoVenda int , 
@CodigoItemEstoque int , 
@ValorItem float = null , 
@Quantidade int = null , 
@Valor float = null , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- UPDATE a row in the table
UPDATE [dbo].[ItensVendas]
SET
	[ValorItem] = @ValorItem ,
	[Quantidade] = @Quantidade ,
	[Valor] = @Valor
WHERE
[CodigoVenda] = @CodigoVenda
AND [CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItensVendas_Delete]    Script Date: 11/23/2009 00:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItensVendas_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItensVendas_Delete
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int  
		@CodigoItemEstoque int  

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will delete 1 row from the table ''ItensVendas'' 

----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItensVendas_Delete]
@CodigoVenda int , 
@CodigoItemEstoque int , 
@ErrorCode int OUTPUT

AS

SET NOCOUNT ON

-- DELETE a row from the table
DELETE FROM [dbo].[ItensVendas]
WHERE
[CodigoVenda] = @CodigoVenda
AND [CodigoItemEstoque] = @CodigoItemEstoque


-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithItensVendasUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithItensVendasUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithItensVendasUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''ItensVendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithItensVendasUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_ItensVendas_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithHistoricoVendaUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithHistoricoVendaUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithHistoricoVendaUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''HistoricoVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithHistoricoVendaUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_HistoricoVenda_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithMarkupCompraUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithMarkupCompraUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithMarkupCompraUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''MarkupCompra''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithMarkupCompraUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_MarkupCompra_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithMarkupDiferencaUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithMarkupDiferencaUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithMarkupDiferencaUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''MarkupDiferenca''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithMarkupDiferencaUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_MarkupDiferenca_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithMarkupVendaUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithMarkupVendaUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithMarkupVendaUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''MarkupVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithMarkupVendaUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_MarkupVenda_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithVendasMesUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithVendasMesUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithVendasMesUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''VendasMes''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithVendasMesUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_VendasMes_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ItemEstoque_SelectOneWithHistoricoCompraUsingCodigoItemEstoque]    Script Date: 11/23/2009 00:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ItemEstoque_SelectOneWithHistoricoCompraUsingCodigoItemEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_ItemEstoque_SelectOneWithHistoricoCompraUsingCodigoItemEstoque
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoItemEstoque int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''ItemEstoque'' and also the respective child records from ''HistoricoCompra''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_ItemEstoque_SelectOneWithHistoricoCompraUsingCodigoItemEstoque]
@CodigoItemEstoque int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_ItemEstoque_SelectByPrimaryKey @CodigoItemEstoque = @CodigoItemEstoque ,@ErrorCode=@ErrorCode
EXEC sp_HistoricoCompra_SelectAllByForeignKeyItemEstoque  @CodigoItemEstoque = @CodigoItemEstoque, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectOneWithItensVendasUsingCodigoVenda]    Script Date: 11/23/2009 00:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectOneWithItensVendasUsingCodigoVenda]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectOneWithItensVendasUsingCodigoVenda
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' and also the respective child records from ''ItensVendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectOneWithItensVendasUsingCodigoVenda]
@CodigoVenda int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Vendas_SelectByPrimaryKey @CodigoVenda = @CodigoVenda ,@ErrorCode=@ErrorCode
EXEC sp_ItensVendas_SelectAllByForeignKeyVendas  @CodigoVenda = @CodigoVenda, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendas_SelectOneWithPagamentoVendaUsingCodigoVenda]    Script Date: 11/23/2009 00:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendas_SelectOneWithPagamentoVendaUsingCodigoVenda]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendas_SelectOneWithPagamentoVendaUsingCodigoVenda
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoVenda int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendas'' and also the respective child records from ''PagamentoVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendas_SelectOneWithPagamentoVendaUsingCodigoVenda]
@CodigoVenda int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Vendas_SelectByPrimaryKey @CodigoVenda = @CodigoVenda ,@ErrorCode=@ErrorCode
EXEC sp_PagamentoVenda_SelectAllByForeignKeyVendas  @CodigoVenda = @CodigoVenda, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TipoPagamento_SelectOneWithVendasUsingCodigoTipoPagamento]    Script Date: 11/23/2009 00:20:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_TipoPagamento_SelectOneWithVendasUsingCodigoTipoPagamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_TipoPagamento_SelectOneWithVendasUsingCodigoTipoPagamento
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:10

INPUTS	: 
		@CodigoTipoPagamento int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''TipoPagamento'' and also the respective child records from ''Vendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_TipoPagamento_SelectOneWithVendasUsingCodigoTipoPagamento]
@CodigoTipoPagamento int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_TipoPagamento_SelectByPrimaryKey @CodigoTipoPagamento = @CodigoTipoPagamento ,@ErrorCode=@ErrorCode
EXEC sp_Vendas_SelectAllByForeignKeyTipoPagamento  @CodigoTipoPagamento = @CodigoTipoPagamento, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cidade_SelectOneWithClienteUsingCodigoCidade]    Script Date: 11/23/2009 00:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cidade_SelectOneWithClienteUsingCodigoCidade]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cidade_SelectOneWithClienteUsingCodigoCidade
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCidade int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Cidade'' and also the respective child records from ''Cliente''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cidade_SelectOneWithClienteUsingCodigoCidade]
@CodigoCidade int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Cidade_SelectByPrimaryKey @CodigoCidade = @CodigoCidade ,@ErrorCode=@ErrorCode
EXEC sp_Cliente_SelectAllByForeignKeyCidade  @CodigoCidade = @CodigoCidade, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectOneWithVendasUsingCodigoCliente]    Script Date: 11/23/2009 00:19:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_SelectOneWithVendasUsingCodigoCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_SelectOneWithVendasUsingCodigoCliente
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Cliente'' and also the respective child records from ''Vendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_SelectOneWithVendasUsingCodigoCliente]
@CodigoCliente int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Cliente_SelectByPrimaryKey @CodigoCliente = @CodigoCliente ,@ErrorCode=@ErrorCode
EXEC sp_Vendas_SelectAllByForeignKeyCliente  @CodigoCliente = @CodigoCliente, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectOneWithPagamentoVendaUsingCodigoCliente]    Script Date: 11/23/2009 00:19:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Cliente_SelectOneWithPagamentoVendaUsingCodigoCliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Cliente_SelectOneWithPagamentoVendaUsingCodigoCliente
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoCliente int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Cliente'' and also the respective child records from ''PagamentoVenda''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Cliente_SelectOneWithPagamentoVendaUsingCodigoCliente]
@CodigoCliente int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Cliente_SelectByPrimaryKey @CodigoCliente = @CodigoCliente ,@ErrorCode=@ErrorCode
EXEC sp_PagamentoVenda_SelectAllByForeignKeyCliente  @CodigoCliente = @CodigoCliente, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_FormaPagamento_SelectOneWithVendasUsingCodigoFormaPagamento]    Script Date: 11/23/2009 00:19:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_FormaPagamento_SelectOneWithVendasUsingCodigoFormaPagamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_FormaPagamento_SelectOneWithVendasUsingCodigoFormaPagamento
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoFormaPagamento int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''FormaPagamento'' and also the respective child records from ''Vendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_FormaPagamento_SelectOneWithVendasUsingCodigoFormaPagamento]
@CodigoFormaPagamento int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_FormaPagamento_SelectByPrimaryKey @CodigoFormaPagamento = @CodigoFormaPagamento ,@ErrorCode=@ErrorCode
EXEC sp_Vendas_SelectAllByForeignKeyFormaPagamento  @CodigoFormaPagamento = @CodigoFormaPagamento, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Vendedor_SelectOneWithVendasUsingCodigoVendedor]    Script Date: 11/23/2009 00:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Vendedor_SelectOneWithVendasUsingCodigoVendedor]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Vendedor_SelectOneWithVendasUsingCodigoVendedor
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:11

INPUTS	: 
		@CodigoVendedor int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Vendedor'' and also the respective child records from ''Vendas''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Vendedor_SelectOneWithVendasUsingCodigoVendedor]
@CodigoVendedor int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Vendedor_SelectByPrimaryKey @CodigoVendedor = @CodigoVendedor ,@ErrorCode=@ErrorCode
EXEC sp_Vendas_SelectAllByForeignKeyVendedor  @CodigoVendedor = @CodigoVendedor, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Grupo_SelectOneWithItemEstoqueUsingCodigoGrupo]    Script Date: 11/23/2009 00:19:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_Grupo_SelectOneWithItemEstoqueUsingCodigoGrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'/*
---------------------------------------------------------------------------------------------------
OBJECT NAME : sp_Grupo_SelectOneWithItemEstoqueUsingCodigoGrupo
						
AUTHOR	:	Ignyte Software © 2009
DATE	:	29/9/2009 00:37:09

INPUTS	: 
		@CodigoGrupo int 

OUTPUTS	: 
		@Error     - The return code indicating if there was an error

DESCRIPTION : This stored procedure will select a row from the table ''Grupo'' and also the respective child records from ''ItemEstoque''
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[sp_Grupo_SelectOneWithItemEstoqueUsingCodigoGrupo]
@CodigoGrupo int ,
@ErrorCode int OUTPUT
AS

SET NOCOUNT ON

-- SELECT a row from the main table
EXEC sp_Grupo_SelectByPrimaryKey @CodigoGrupo = @CodigoGrupo ,@ErrorCode=@ErrorCode
EXEC sp_ItemEstoque_SelectAllByForeignKeyGrupo  @CodigoGrupo = @CodigoGrupo, @ErrorCode=@ErrorCode

-- Get the Error Code for the statment just executed
SET @ErrorCode = @@ERROR' 
END
GO
/****** Object:  ForeignKey [FK_Cliente_Cidade]    Script Date: 11/23/2009 00:21:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Cliente_Cidade]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cliente]'))
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cidade] FOREIGN KEY([CodigoCidade])
REFERENCES [dbo].[Cidade] ([CodigoCidade])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cidade]
GO
/****** Object:  ForeignKey [FK_HistoricoCompra_ItemEstoque]    Script Date: 11/23/2009 00:21:04 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HistoricoCompra_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[HistoricoCompra]'))
ALTER TABLE [dbo].[HistoricoCompra]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoCompra_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[HistoricoCompra] CHECK CONSTRAINT [FK_HistoricoCompra_ItemEstoque]
GO
/****** Object:  ForeignKey [FK_HistoricoVenda_ItemEstoque]    Script Date: 11/23/2009 00:21:06 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HistoricoVenda_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[HistoricoVenda]'))
ALTER TABLE [dbo].[HistoricoVenda]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoVenda_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[HistoricoVenda] CHECK CONSTRAINT [FK_HistoricoVenda_ItemEstoque]
GO
/****** Object:  ForeignKey [FK_ItemEstoque_Grupo]    Script Date: 11/23/2009 00:21:09 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItemEstoque_Grupo]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItemEstoque]'))
ALTER TABLE [dbo].[ItemEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemEstoque_Grupo] FOREIGN KEY([CodigoGrupo])
REFERENCES [dbo].[Grupo] ([CodigoGrupo])
GO
ALTER TABLE [dbo].[ItemEstoque] CHECK CONSTRAINT [FK_ItemEstoque_Grupo]
GO
/****** Object:  ForeignKey [FK_ItensVendas_ItemEstoque]    Script Date: 11/23/2009 00:21:11 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItensVendas_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItensVendas]'))
ALTER TABLE [dbo].[ItensVendas]  WITH CHECK ADD  CONSTRAINT [FK_ItensVendas_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[ItensVendas] CHECK CONSTRAINT [FK_ItensVendas_ItemEstoque]
GO
/****** Object:  ForeignKey [FK_ItensVendas_Vendas]    Script Date: 11/23/2009 00:21:11 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ItensVendas_Vendas]') AND parent_object_id = OBJECT_ID(N'[dbo].[ItensVendas]'))
ALTER TABLE [dbo].[ItensVendas]  WITH CHECK ADD  CONSTRAINT [FK_ItensVendas_Vendas] FOREIGN KEY([CodigoVenda])
REFERENCES [dbo].[Vendas] ([CodigoVenda])
GO
ALTER TABLE [dbo].[ItensVendas] CHECK CONSTRAINT [FK_ItensVendas_Vendas]
GO
/****** Object:  ForeignKey [FK_MarkupCompra_ItemEstoque]    Script Date: 11/23/2009 00:21:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MarkupCompra_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[MarkupCompra]'))
ALTER TABLE [dbo].[MarkupCompra]  WITH CHECK ADD  CONSTRAINT [FK_MarkupCompra_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[MarkupCompra] CHECK CONSTRAINT [FK_MarkupCompra_ItemEstoque]
GO
/****** Object:  ForeignKey [FK_MarkupDiferenca_ItemEstoque]    Script Date: 11/23/2009 00:21:25 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MarkupDiferenca_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[MarkupDiferenca]'))
ALTER TABLE [dbo].[MarkupDiferenca]  WITH CHECK ADD  CONSTRAINT [FK_MarkupDiferenca_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[MarkupDiferenca] CHECK CONSTRAINT [FK_MarkupDiferenca_ItemEstoque]
GO
/****** Object:  ForeignKey [FK_MarkupVenda_ItemEstoque]    Script Date: 11/23/2009 00:21:33 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MarkupVenda_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[MarkupVenda]'))
ALTER TABLE [dbo].[MarkupVenda]  WITH CHECK ADD  CONSTRAINT [FK_MarkupVenda_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[MarkupVenda] CHECK CONSTRAINT [FK_MarkupVenda_ItemEstoque]
GO
/****** Object:  ForeignKey [FK_PagamentoVenda_Cliente]    Script Date: 11/23/2009 00:21:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagamentoVenda_Cliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagamentoVenda]'))
ALTER TABLE [dbo].[PagamentoVenda]  WITH CHECK ADD  CONSTRAINT [FK_PagamentoVenda_Cliente] FOREIGN KEY([CodigoCliente])
REFERENCES [dbo].[Cliente] ([CodigoCliente])
GO
ALTER TABLE [dbo].[PagamentoVenda] CHECK CONSTRAINT [FK_PagamentoVenda_Cliente]
GO
/****** Object:  ForeignKey [FK_PagamentoVenda_Vendas]    Script Date: 11/23/2009 00:21:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagamentoVenda_Vendas]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagamentoVenda]'))
ALTER TABLE [dbo].[PagamentoVenda]  WITH NOCHECK ADD  CONSTRAINT [FK_PagamentoVenda_Vendas] FOREIGN KEY([CodigoVenda])
REFERENCES [dbo].[Vendas] ([CodigoVenda])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[PagamentoVenda] NOCHECK CONSTRAINT [FK_PagamentoVenda_Vendas]
GO
/****** Object:  ForeignKey [FK_Vendas_Cliente]    Script Date: 11/23/2009 00:21:44 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Vendas_Cliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[Vendas]'))
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Cliente] FOREIGN KEY([CodigoCliente])
REFERENCES [dbo].[Cliente] ([CodigoCliente])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Cliente]
GO
/****** Object:  ForeignKey [FK_Vendas_FormaPagamento]    Script Date: 11/23/2009 00:21:44 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Vendas_FormaPagamento]') AND parent_object_id = OBJECT_ID(N'[dbo].[Vendas]'))
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_FormaPagamento] FOREIGN KEY([CodigoFormaPagamento])
REFERENCES [dbo].[FormaPagamento] ([CodigoFormaPagamento])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_FormaPagamento]
GO
/****** Object:  ForeignKey [FK_Vendas_TipoPagamento]    Script Date: 11/23/2009 00:21:45 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Vendas_TipoPagamento]') AND parent_object_id = OBJECT_ID(N'[dbo].[Vendas]'))
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_TipoPagamento] FOREIGN KEY([CodigoTipoPagamento])
REFERENCES [dbo].[TipoPagamento] ([CodigoTipoPagamento])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_TipoPagamento]
GO
/****** Object:  ForeignKey [FK_Vendas_Vendedor]    Script Date: 11/23/2009 00:21:45 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Vendas_Vendedor]') AND parent_object_id = OBJECT_ID(N'[dbo].[Vendas]'))
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Vendedor] FOREIGN KEY([CodigoVendedor])
REFERENCES [dbo].[Vendedor] ([CodigoVendedor])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Vendedor]
GO
/****** Object:  ForeignKey [FK_VendasMes_ItemEstoque]    Script Date: 11/23/2009 00:21:49 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VendasMes_ItemEstoque]') AND parent_object_id = OBJECT_ID(N'[dbo].[VendasMes]'))
ALTER TABLE [dbo].[VendasMes]  WITH CHECK ADD  CONSTRAINT [FK_VendasMes_ItemEstoque] FOREIGN KEY([CodigoItemEstoque])
REFERENCES [dbo].[ItemEstoque] ([CodigoItemEstoque])
GO
ALTER TABLE [dbo].[VendasMes] CHECK CONSTRAINT [FK_VendasMes_ItemEstoque]
GO
