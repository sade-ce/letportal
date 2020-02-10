﻿using LetPortal.Core.Versions;
using LetPortal.Portal.Entities.SectionParts;
using System.Collections.Generic;

namespace LetPortal.Versions.Components
{
    public class Standard_0_0_2 : IPortalVersion
    {
        public string VersionNumber => "0.0.2";

        public void Downgrade(IVersionContext versionContext)
        {
            versionContext.DeleteData<StandardComponent>("5d615e501773a96ee8eb5ed3");
            versionContext.DeleteData<StandardComponent>("5d6222ec3aae6a79ecf035e9");
            versionContext.DeleteData<StandardComponent>("5d63423dbaac7d4790b7d300");
        }

        public void Upgrade(IVersionContext versionContext)
        {
            var userFormStandard = new StandardComponent
            {
                Id = "5d615e501773a96ee8eb5ed3",
                Name = "user-form",
                DisplayName = "User Form",
                LayoutType = PageSectionLayoutType.OneColumn,
                Controls = new List<Portal.Entities.SectionParts.Controls.PageControl>
                {
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "be0bbde4-b189-9e7d-95ab-98af8e681559",
                        Name = "id",
                        Order = 0,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Textbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "id"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "id"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "true"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "true"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "id"
                           }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "b1b51c52-1312-c5ea-2e5a-8296392da949",
                        Name = "username",
                        Order = 1,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Label,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Username"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a username"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "!!queryparams.id"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "username"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "da8c538a-3791-596d-93e2-ec01cbe8b198",
                        Name = "email",
                        Order = 2,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Email,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Email"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a email"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "email"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a email"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "This field requires maximum 250 characters",
                                ValidatorOption = "250"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Email,
                                IsActive = true,
                                ValidatorMessage = "Please enter a correct email format"
                            }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "b1b51c52-1312-c5ea-2e5a-8296392da949",
                        Name = "isConfirmedEmail",
                        Order = 3,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Checkbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Confirmed Email"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = ""
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "isConfirmedEmail"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "55d8d892-bbe0-f8c0-b3c6-b18b186b8ec2",
                        Name = "isLockoutEnabled",
                        Order = 4,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Checkbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Lockout Enabled"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = ""
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "isLockoutEnabled"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "55d8d892-bbe0-f8c0-b3c6-b18b186b8ec2",
                        Name = "lockoutEndDate",
                        Order = 4,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Label,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Lockout End Date"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = ""
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "lockoutEndDate"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "55d8d892-bbe0-f8c0-b3c6-b18b186b8ec2",
                        Name = "roles",
                        Order = 4,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Select,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Roles"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = ""
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "roles"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "multiple",
                               Value = "true"
                           }
                        },
                        DatasourceOptions = new Portal.Entities.Shared.DatasourceOptions
                        {
                            Type = Portal.Entities.Shared.DatasourceControlType.Database,
                            DatabaseOptions = new Portal.Entities.Shared.DatabaseOptions
                            {
                                DatabaseConnectionId = Constants.IdentityDatabaseId,
                                EntityName = "roles",
                                Query = versionContext.ConnectionType == Core.Persistences.ConnectionType.MongoDB ?
                                "{\r\n  \"$query\": {\r\n    \"roles\": [\r\n      {\r\n        \"$project\": {\r\n          \"name\": \"$displayName\",\r\n          \"value\": \"$name\"\r\n        }\r\n      }\r\n    ]\r\n  }\r\n}"
                                : (versionContext.ConnectionType == Core.Persistences.ConnectionType.MySQL ? "Select `displayName` as name, name as value from `roles`" : "Select \"displayName\" as name, name as value from roles")
                            }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please select at least one role",
                                ValidatorOption = ""
                            }
                        }
                    }
                }
            };

            var registerNewUserFormStandard = new StandardComponent
            {
                Id = "5d6222ec3aae6a79ecf035e9",
                Name = "register-form",
                DisplayName = "Register Form",
                LayoutType = PageSectionLayoutType.OneColumn,
                Controls = new List<Portal.Entities.SectionParts.Controls.PageControl>
                {
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "b1b51c52-1312-c5ea-2e5a-8296392da949",
                        Name = "username",
                        Order = 1,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Textbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Username"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a username"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "username"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a username"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Regex,
                                IsActive = true,
                                ValidatorMessage = "Please enter only characters and numberic",
                                ValidatorOption = "[A-Za-z0-9]*"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "This field requires maximum 50 characters",
                                ValidatorOption = "50"
                            }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "da8c538a-3791-596d-93e2-ec01cbe8b198",
                        Name = "password",
                        Order = 2,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Password,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Password"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a password"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "password"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a password"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "Password requires maximum 50 characters",
                                ValidatorOption = "50"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MinLength,
                                IsActive = true,
                                ValidatorMessage = "Password must have at least {{option}} characters",
                                ValidatorOption = "6"
                            }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "b1b51c52-1312-c5ea-2e5a-8296392da949",
                        Name = "repassword",
                        Order = 3,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Password,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Confirm password"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a confirm password"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "repassword"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a confirm password"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "This field requires maximum 50 characters",
                                ValidatorOption = "50"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.EqualTo,
                                IsActive = true,
                                ValidatorMessage = "This field must be equal to {{option}}",
                                ValidatorOption = "password"
                            }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "55d8d892-bbe0-f8c0-b3c6-b18b186b8ec2",
                        Name = "email",
                        Order = 4,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Email,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Email"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a email"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "email"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a email"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "This field requires maximum 250 characters",
                                ValidatorOption = "250"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Email,
                                IsActive = true,
                                ValidatorMessage = "This field must be email format"
                            }
                        }
                    }
                }
            };

            var roleStandard = new StandardComponent
            {
                Id = "5d63423dbaac7d4790b7d300",
                Name = "role-form",
                DisplayName = "Role Form",
                LayoutType = PageSectionLayoutType.OneColumn,
                Controls = new List<Portal.Entities.SectionParts.Controls.PageControl>
                {
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "be0bbde4-b189-9e7d-95ab-98af8e681559",
                        Name = "id",
                        Order = 0,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Textbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "id"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "id"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "true"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "true"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "id"
                           }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "b1b51c52-1312-c5ea-2e5a-8296392da949",
                        Name = "name",
                        Order = 1,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Textbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Role Name"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a role name"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "!!queryparams.id"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "name"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a name"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "This field requires maximum 50 characters",
                                ValidatorOption = "50"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Regex,
                                IsActive = true,
                                ValidatorMessage = "Please enter only characters",
                                ValidatorOption = "[A-Za-z]*"
                            }
                        }
                    },
                    new Portal.Entities.SectionParts.Controls.PageControl
                    {
                        Id = "b1b51c52-1312-c5ea-2e5a-8296392da949",
                        Name = "displayName",
                        Order = 2,
                        Type = Portal.Entities.SectionParts.Controls.ControlType.Textbox,
                        Options = new List<Portal.Entities.Pages.ShellOption>
                        {
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "label",
                               Value = "Role Display Name"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "tooltip",
                               Value = "Enter a display name"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "disabled",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "hidden",
                               Value = "false"
                           },
                           new Portal.Entities.Pages.ShellOption
                           {
                               Key = "bindname",
                               Value = "displayName"
                           }
                        },
                        Validators = new List<Portal.Entities.SectionParts.Controls.PageControlValidator>
                        {
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.Required,
                                IsActive = true,
                                ValidatorMessage = "Please enter a display name"
                            },
                            new Portal.Entities.SectionParts.Controls.PageControlValidator
                            {
                                ValidatorType = Portal.Entities.SectionParts.Controls.ValidatorType.MaxLength,
                                IsActive = true,
                                ValidatorMessage = "This field requires maximum 50 characters",
                                ValidatorOption = "50"
                            }
                        }
                    }
                }
            };

            VersionUtils.GenerateControlEvents(userFormStandard);
            VersionUtils.GenerateControlEvents(registerNewUserFormStandard);
            VersionUtils.GenerateControlEvents(roleStandard);

            versionContext.InsertData(userFormStandard);
            versionContext.InsertData(registerNewUserFormStandard);
            versionContext.InsertData(roleStandard);
        }
    }
}
