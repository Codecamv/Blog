using System.Collections.Generic;
using EPiServer.Templates.Alloy.LanguageTool.Domain;
using EPiServer.Templates.Alloy.LanguageTool.Extensions;
using EPiServer.Templates.Alloy.Models.Pages;

namespace EPiServer.Templates.Alloy.LanguageTool.Resources
{
    public class Sv : IInitialTranslations
    {
        private TranslationGroup[] _initialArray;
        public string IetfLanguageTag { get { return "sv"; } }

        public TranslationGroup[] Initials
        {
            get
            {
                if (_initialArray != null)
                {
                    return _initialArray;
                }
                var initials = new List<TranslationGroup>();
                
                var articlePage = new TranslationGroup
                    {
                        ContentTypeName = typeof(ArticlePage).Name, // Translations editable on pages of type ArticlePage.
                        Translations = new[]
                            {
                                // Initial swedish article page translations goes here
                                new Translation{ResourceKey = "/some/sample/key", Text = "Svensk demotext"},
                                new Translation{ResourceKey = "/some/other/sample/key", Text = "En annan svensk demotext"},

                            }
                    };
                initials.SetupAndAdd(articlePage, IetfLanguageTag);

                var system = new TranslationGroup
                    {
                        Translations = new[]
                            {
                                // These are system translations used in this language tool
                                new Translation{ResourceKey = "/plugins/languagetool/plugin/title", Text = "�vers�ttningar f�r"},
                                new Translation{ResourceKey = "/plugins/languagetool/plugin/description", Text = "Det h�r verktyget l�ter dig �ndra p� inneh�llstypspecifika texter; som t.ex. texter bundna till artikelsidtypen. F�r globala �vers�ttningar (s�dana som inte �r bundna till inneh�llstyper) v�nligen anv�nd verktyget i EPiServers globala meny. F�r att �ndra p� texter i andra spr�k, v�nligen byt spr�kkontext."},
                                new Translation{ResourceKey = "/plugins/languagetool/tool/title", Text = "�vers�ttningar f�r samtliga inneh�llstyper"},
                                new Translation{ResourceKey = "/plugins/languagetool/tool/description", Text = "Det h�r verktyget l�ter dig �ndra p� inneh�llstexter oavsett inneh�llstyp. F�r att �ndra p� texter i andra spr�k, v�nligen byt spr�kkontext."},
                                new Translation{ResourceKey = "/plugins/languagetool/globaltranslations", Text = "Globala �vers�ttningar"},
                                new Translation{ResourceKey = "/plugins/languagetool/resourcekey", Text = "�vers�ttningsnyckel"},
                                new Translation{ResourceKey = "/plugins/languagetool/text", Text = "�vers�ttning"},
                                new Translation{ResourceKey = "/plugins/languagetool/update", Text = "Uppdatera"},
                                new Translation{ResourceKey = "/plugins/languagetool/created", Text = "Skapad"},
                                new Translation{ResourceKey = "/plugins/languagetool/updated", Text = "�ndrad"},
                                new Translation{ResourceKey = "/plugins/languagetool/updatedby", Text = "�ndrad av"},
                                new Translation{ResourceKey = "/plugins/languagetool/success", Text = "�vers�ttningen uppdaterad."},
                                new Translation{ResourceKey = "/plugins/languagetool/errors/noid", Text = "FEL: Det finns inget id f�r den h�r �vers�ttningen."},
                                new Translation{ResourceKey = "/plugins/languagetool/errors/antiforgery", Text = "FEL: Antiforgery valideringen misslyckades."},
                                new Translation{ResourceKey = "/plugins/languagetool/errors/notguid", Text = "FEL: Id-v�rdet p� den h�r �vers�ttningen �r inte en Guid."},
                                new Translation{ResourceKey = "/plugins/languagetool/errors/notranslation", Text = "FEL: Det finns ingen �vers�ttning med detta id i databasen."},
                                
                                new Translation{ResourceKey = "/globalmenu/toolbox/label", Text = "Verktyg"},
                                new Translation{ResourceKey = "/globalmenu/toolbox/translations/label", Text = "�vers�ttningar"},
                            }
                    };
                initials.SetupAndAdd(system, IetfLanguageTag);

                _initialArray = initials.ToArray();
                return _initialArray;
            }
        }
    }
}
