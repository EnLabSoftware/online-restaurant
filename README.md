# online-restaurant
A sample enterprise application for restaurant business developed in May 2014 using ASP.NET MVC 5, WinForm, DevExpress, WCF, EF, and SQL Server

## Project Specifications ##

A typical restaurant includes front-office and back-office operations that the software is aimed to support

* Front-end: Buyers can search, browse, and order food online
* Back-end: Staff use a winform application to maintain menus, process orders, and access dashboard for analytic purposes

## Architecture ##
* Three-tier architecture with Generic Repository, Application Logic, and WCF Service to expose services to front-end and back-end applications
* Front-end web site with ASP.NET MVC 5 (Razor) consume WCF Service via HttpClient
* Back-end UI with WinForm and DevExpress consuming WCF Service via service reference
