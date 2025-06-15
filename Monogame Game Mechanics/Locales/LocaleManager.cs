using Monogame_Game_Mechanics.General.Constants;
using Monogame_Game_Mechanics.General.Enums;
using Monogame_Game_Mechanics.Resources.Languages;
using System.Globalization;
using System.Resources;

[ assembly: NeutralResourcesLanguage( "en" ) ]

namespace Monogame_Game_Mechanics.Locales
{
	public class LocaleManager
	{
		public LocaleManager()
		{
			CurrentLanguage = Languages.English_US;
			GetCultureString( CurrentLanguage );
			resourceManager = new ResourceManager( typeof( LanguageStrings ) );
		}

		public void ChangeLanguage( Languages selectedLanguage )
		{
			CurrentLanguage = selectedLanguage;

		}

		public void GetCultureString( Languages selectedLanguage )
		{
			currentCulture = selectedLanguage switch
			{
				Languages.English_US => CultureConstants.ENGLISH_UNITED_STATES,
				Languages.Spanish_MX => CultureConstants.SPANISH_MEXICO,
				_ => CultureConstants.ENGLISH_UNITED_STATES
			};
		}

		public string GetString( string key )
		{
			return resourceManager.GetString( key, CultureInfo.CreateSpecificCulture( currentCulture ) );
		}

		private readonly ResourceManager resourceManager;
		private string currentCulture;
		public Languages CurrentLanguage { get; private set; }
	}
}
