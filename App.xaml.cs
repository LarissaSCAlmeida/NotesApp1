﻿using Microsoft.Maui.Media;

using System.Security.Claims;

<? xml version = "1.0" encoding = "UTF-8" ?>
< Shell
    x:Class = "NotesApp.AppShell"
    xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns: local = "clr-namespace:NotesApp"
    Shell.FlyoutBehavior = "Disabled"
    Title = "NotesApp" >

    < TabBar >
        < ShellContent
            Title = "Home"
            ContentTemplate = "{DataTemplate local:MainPage}"
            Route = "MainPage" />

        < ShellContent
            Title = "Anotações"
            ContentTemplate = "{DataTemplate local:NotePage}"
            Route = "NotePage" />
    </ TabBar >

</ Shell >
