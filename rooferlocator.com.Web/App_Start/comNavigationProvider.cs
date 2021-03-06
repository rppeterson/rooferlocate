﻿using Abp.Application.Navigation;
using Abp.Localization;
using rooferlocator.com.Authorization;

namespace rooferlocator.com.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class comNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        L("HomePage"),
                        url: "/",
                        icon: "fa fa-home",
                        requiresAuthentication: false
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "/Tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        L("About"),
                        url: "/About",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Members",
                        L("Members"),
                        url: "/Members",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Register",
                        L("Register"),
                        url: "#/register",
                        icon: "fa fa-info"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Register",
                        L("Register"),
                        url: "#/register",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, comConsts.LocalizationSourceName);
        }
    }
}
