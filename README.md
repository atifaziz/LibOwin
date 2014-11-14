LibOwin [![Build status](https://ci.appveyor.com/api/projects/status/uvrk7uy2rx99m69n?svg=true)](https://ci.appveyor.com/project/damianh/libowin) [![NuGet Status](http://img.shields.io/nuget/v/LibOwin.svg?style=flat)](https://www.nuget.org/packages/LibOwin/)
=====

Types that help work with an owin environment primarily designed to be used internally by owin middleware and component authors. This is shipped as a dependency free nuget source package.

The types in this project are forked / extracted from [Katana Project's](http://katanaproject.codeplex.com/) Microsoft.Owin. It is my understanding that Microsoft are focusing on AspNet5 and won't be putting any further time into maintaining these owin types and given that there are upcoming changes to the owin spec, I've decided to create this project to continue development and maintenance.

Using
-----
Install via nuget:
`install-package LibOwin`

 - This will add a single file to your project `App_Packages\LibOwin.X.Y\LibOwin.cs`.
 - The types in this will be in namespace `$rootNamespace.Owin` where `$rootNamespace` is the default root namespace of the projects.
 - All type are internal so they are not inadvertently surfaced as your public API. To make them public add `LIBOWIN_PUBLIC` compilation symbol to your project. Due to the namespace transform, your public OWIN types won't clash with the same types in another middleware / component.
 

CI nuget feed: http://www.myget.org/f/dh
