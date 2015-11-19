﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace Acceleratio.SPDG.Generator.Objects.Client
{
    public class SPDGClientRoleAssignment : SPDGRoleAssignment
    {

        private RoleAssignment _roleAssignment;

        public SPDGClientRoleAssignment(RoleAssignment roleAssignment, SPDGPrincipal member, IEnumerable<SPDGRoleDefinition> roleDefinitionBindings)
            : base(member, roleDefinitionBindings)
        {
            _roleAssignment = roleAssignment;
        }

        public SPDGClientRoleAssignment(SPDGPrincipal member)
            : base(member, new List<SPDGRoleDefinition>())
        {
        }

        //public override void ImportRoleDefinitionBindings(IEnumerable<SPDocKitRoleDefinition> roleDefinitions)
        //{
        //    RoleDefinitionBindingCollection roleBindingsFromSelection = new RoleDefinitionBindingCollection(_roleAssignment.Context);
        //    foreach (var spDocKitRoleDefinition in roleDefinitions)
        //    {
        //        roleBindingsFromSelection.Add((spDocKitRoleDefinition as ClientRoleDefinition).RoleDefinition);
        //    }
        //    _roleAssignment.ImportRoleDefinitionBindings(roleBindingsFromSelection);
        //}

        public override void Update()
        {
            _roleAssignment.Update();
            _roleAssignment.Context.ExecuteQuery();
        }
    }
}
