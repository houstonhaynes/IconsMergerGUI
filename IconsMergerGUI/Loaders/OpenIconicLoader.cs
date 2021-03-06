﻿#region Using directives
using System.IO;
using LiteDB;
#endregion

namespace IconsMergerGUI.Loaders
{
    public class OpenIconicLoader : IconLoader
    {
        public OpenIconicLoader( LiteDatabase db, string pack )
            : base( db, pack )
        {
        }

        protected override string GetIconName( string path )
        {
            return Path.GetFileNameWithoutExtension( path );
        }

        protected override string GetIconNormalizedName( string name )
        {
            return name;
        }

        protected override string[] FindFiles( string path )
        {
            return Directory.GetFiles( Path.Combine( path, "svg" ), "*.svg" );
        }
    }
}
