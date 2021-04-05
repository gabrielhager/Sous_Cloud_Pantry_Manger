﻿/*
Deployment script for SousData

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SousData"
:setvar DefaultFilePrefix "SousData"
:setvar DefaultDataPath "C:\Users\gabri\AppData\Local\Microsoft\VisualStudio\SSDT\Sous_Cloud_Pantry"
:setvar DefaultLogPath "C:\Users\gabri\AppData\Local\Microsoft\VisualStudio\SSDT\Sous_Cloud_Pantry"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Calendar]...';


GO
ALTER TABLE [dbo].[Calendar] DROP CONSTRAINT [FK__Calendar__UserID__2C3393D0];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Grocery_List]...';


GO
ALTER TABLE [dbo].[Grocery_List] DROP CONSTRAINT [FK__Grocery_L__UserI__2D27B809];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Ingredients]...';


GO
ALTER TABLE [dbo].[Ingredients] DROP CONSTRAINT [FK__Ingredien__measu__2E1BDC42];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Pantry]...';


GO
ALTER TABLE [dbo].[Pantry] DROP CONSTRAINT [FK__Pantry__UserID__2F10007B];


GO
PRINT N'Dropping unnamed constraint on [dbo].[Recipes]...';


GO
ALTER TABLE [dbo].[Recipes] DROP CONSTRAINT [FK__Recipes__Ingredi__300424B4];


GO
PRINT N'Update complete.';


GO