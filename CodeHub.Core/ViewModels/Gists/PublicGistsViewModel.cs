﻿using System.Collections.Generic;
using CodeHub.Core.Services;
using GitHubSharp;
using GitHubSharp.Models;

namespace CodeHub.Core.ViewModels.Gists
{
    public class PublicGistsViewModel : GistsViewModel
    {
        public PublicGistsViewModel(IApplicationService application)
            : base(application)
        {
        }

        protected override GitHubRequest<List<GistModel>> CreateRequest()
        {
            return Application.Client.Gists.GetPublicGists();
        }
    }
}
