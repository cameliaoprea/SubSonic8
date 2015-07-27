//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by ResW File Code Generator (http://reswcodegen.codeplex.com)
// 	ResW File Code Generator was written by Christian Resma Helle
// 	and is under GNU General Public License version 2 (GPLv2)
// 
// 	This code contains a helper class exposing property representations
// 	of the string resources defined in the specified .ResW file
// 
// 	Generated: 07/27/2015 20:54:52
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
namespace Subsonic8.Playback
{
    using System;

    using Windows.ApplicationModel.Resources;
    
    
    public partial class PlaybackViewModelStrings
    {
        
        private static ResourceLoader resourceLoader;
        
        static PlaybackViewModelStrings()
        {
            string executingAssemblyName;
            executingAssemblyName = Windows.UI.Xaml.Application.Current.GetType().AssemblyQualifiedName;
            string[] executingAssemblySplit;
            executingAssemblySplit = executingAssemblyName.Split(',');
            executingAssemblyName = executingAssemblySplit[1];
            string currentAssemblyName;
            currentAssemblyName = typeof(PlaybackViewModelStrings).AssemblyQualifiedName;
            string[] currentAssemblySplit;
            currentAssemblySplit = currentAssemblyName.Split(',');
            currentAssemblyName = currentAssemblySplit[1];
            try
            {
                resourceLoader = new ResourceLoader("PlaybackViewModelStrings");
            }
            catch (Exception)
            {
                resourceLoader = new ResourceLoader(currentAssemblyName + "/PlaybackViewModelStrings");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Nothing Playing"
        /// </summary>
        public static string ArtistPlaceholder
        {
            get
            {
                return resourceLoader.GetString("ArtistPlaceholder");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Why don't you add some items to the playlist.
        ///It's so lonely out here."
        /// </summary>
        public static string NoItemsPlaceholder
        {
            get
            {
                return resourceLoader.GetString("NoItemsPlaceholder");
            }
        }
    }
}
