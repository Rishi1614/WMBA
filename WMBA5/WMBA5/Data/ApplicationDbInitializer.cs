﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using System.Diagnostics;

namespace WMBA5.Data
{
    public static class ApplicationDbInitializer
    {
        public static async void Seed(IApplicationBuilder applicationBuilder)
        {
            ApplicationDbContext context = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<ApplicationDbContext>();

            WMBAContext wmbaContext = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<WMBAContext>();

            try
            {
                
                //Create the database if it does not exist and apply the Migration
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
                context.Database.Migrate();

                // Create Roles
                var RoleManager = applicationBuilder.ApplicationServices.CreateScope()
                    .ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                List<string> roleNames = new List<string> { "Admin", "Rookie Convenor", "Intermediate Convenor", "Senior Convenor", "Scorekeeper", "Coach" };

                // Team Coach and Scorekeeper roles
                var teams = await wmbaContext.Teams.ToListAsync();
                foreach (var team in teams)
                {
                    // Coach role
                    string coachRoleName = team.TeamName + " - Coach";
                    // Scorekeeper role
                    string scorekeeperRoleName = team.TeamName + " - Scorekeeper";

                    // Append coach and scorekeeper role names to roleNames list
                    roleNames.Add(coachRoleName);
                    roleNames.Add(scorekeeperRoleName);
                }

                IdentityResult roleResult;
                foreach (var roleName in roleNames)
                {
                    var roleExist = await RoleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
                //Create Users
                var userManager = applicationBuilder.ApplicationServices.CreateScope()
                    .ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                /*Create user admin@outlook.com with password "Pa55w@rd" and add it
                to the Admin roles*/
                if (userManager.FindByEmailAsync("admin@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "admin@outlook.com", 
                        Email = "admin@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Admin").Wait();
                    }
                }
                //Create Rookie Convenor User
                if (userManager.FindByEmailAsync("rookconv@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "rookconv@outlook.com",
                        Email = "rookconv@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Rookie Convenor").Wait();
                    }
                }
                //Create Intermediate Convenor User
                if (userManager.FindByEmailAsync("interconv@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "interconv@outlook.com",
                        Email = "interconv@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Intermediate Convenor").Wait();
                    }
                }
                //Create Senior Convenor User
                if (userManager.FindByEmailAsync("seniorconv@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "seniorconv@outlook.com",
                        Email = "seniorconv@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Senior Convenor").Wait();
                    }
                }
                //Create coach Trash Pandas u15 user
                if (userManager.FindByEmailAsync("coach@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "coach@outlook.com",
                        Email = "coach@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Coach").Wait();
                    }
                }
                ////Create coach Trash Pandas u15 user
                //if (userManager.FindByEmailAsync("coachtp15@outlook.com").Result == null)
                //{
                //    IdentityUser user = new IdentityUser
                //    {
                //        UserName = "coachtp15@outlook.com",
                //        Email = "coachtp15@outlook.com",
                //        EmailConfirmed = true
                //    };

                //    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                //    if (result.Succeeded)
                //    {
                //        userManager.AddToRoleAsync(user, "Trash Pandas 15U Coach").Wait();
                //    }
                //}
                ////Create Trash Pandas 15U scorekeeper user
                //if (userManager.FindByEmailAsync("scorekeepertp15@outlook.com").Result == null)
                //{
                //    IdentityUser user = new IdentityUser
                //    {
                //        UserName = "scorekeepertp15@outlook.com",
                //        Email = "scorekeepertp15@outlook.com",
                //        EmailConfirmed = true
                //    };

                //    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                //    if (result.Succeeded)
                //    {
                //        userManager.AddToRoleAsync(user, "Trash Pandas 15U Scorekeeper").Wait();
                //    }
                //}
                //Create scorekeeper user
                if (userManager.FindByEmailAsync("scorekeeper@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "scorekeeper@outlook.com",
                        Email = "scorekeeper@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Scorekeeper").Wait();
                    }
                }
                /*Create user user@outlook.com with password "Pa55w@rd”, not in any role.*/
                if (userManager.FindByEmailAsync("user@outlook.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "user@outlook.com",
                        Email = "user@outlook.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;
                    //Not in any role
                }
                /*and my (Juan) College adress for future testing with the admin role*/
                if (userManager.FindByEmailAsync("jjacoborodrigue1@ncstudents.niagaracollege.ca").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "jjacoborodrigue1@ncstudents.niagaracollege.ca",
                        Email = "jjacoborodrigue1@ncstudents.niagaracollege.ca",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Admin").Wait();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException().Message);
            }
        }
    }
}
