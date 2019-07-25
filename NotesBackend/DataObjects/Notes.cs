using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotesBackend.DataObjects
{
    public class Notes : EntityData
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}