using System.Collections.Generic;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Spells;
using BlueprintCore.Utils;
using GeoEnchanter.Util;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes.Spells;

namespace Archetypes.GeoEnchanter.SpellBook
{
    class GeoEnchanterSpellList
    {
        private static readonly string ListName = "GeoEnchanterSpellList";
        public static void Configure()
        {
            var List = SpellListConfigurator.New(name: ListName, guid: Guids.GeoEnchanterSpellList);

            SpellLevelList[] SpellsByLevel = [
                LevelList(00,["c3a8f31778c3980498d8f00c980be5f5",
                              "95f206566c5261c42aa5b3e7e0d1e36c",
                              "7bc8e27cba24f0e43ae64ed201ad5785",
                              "0557ccee0a86dc44cb3d3f6a3b235329"]),
                LevelList(01,["5590652e1c2225c4ca30c4a699ab3649",
                              "c60969e7f264e6d4b84a1499fdcf9039",
                              "e5af3674bb241f14b9a9f6b0c7dc3d27",
                              "9e1ad5d6f87d19e4d8883d63a6e35568",
                              "4f8181e7a7f1d904fbaea64220e83379",
                              "b065231094a21d14dbf1c3832f776871",
                              "ef768022b0785eb43a18969903c537c4",
                              "4e0e9aba6447d514f88eff1464cc4763",
                              "f6f95242abdfac346befd6f4f6222140",
                              "dd38f33c56ad00a4da386c1afaa49967",
                              "85067a04a97416949b5d1dbf986d93f3",
                              "2c38da66e5a599347ac95b3294acbe00"]),
                LevelList(02,["03a9630394d10164a9410882d31572f0",
                              "d4b28341acdfa9443a3a779acb58be51",
                              "5b77d7cc65b8ab74688e74a37fc2f553",
                              "a900628aea19aa74aad0ece0e65d091a",
                              "14ec7a4e52e90fa47a4c8d63c69fd5c1",
                              "4c3d08935262b6544ae97599b3a9556d",
                              "de7a025d48ad5da4991e7d3c682cf69d",
                              "6b90c773a6543dc49b2505858ce33db5",
                              "b48b4c5ffb4eab0469feba27fc86a023",
                              "446f7bf201dc1934f96ac0a26e324803",
                              "7a5b5bf845779a941a67251539545762",
                              "ae4d3ad6a8fda1542acf2e9bbc13d113",
                              "89940cde01689fb46946b2f8cd7b66b7",
                              "c28de1f98a3f432448e52e5d47c73208",
                              "21ffef7791ce73f468b6fca4d9371e8b",
                              "e84fc922ccf952943b5240293669b171",
                              "30e5dc243f937fc4b95d2f8f4e1b7ff3",
                              "4709274b2080b6444a3c11c6ebbe2404",
                              "65f0b63c45ea82a4f8b8325768a3832d",
                              "0da2046b4517427bb9b2e304ea6342bf",
                              "f0455c9295b53904f9e02fc571dd2ce1"]),
                LevelList(03,["61a7ed778dd93f344a5dacdbad324cc9",
                              "92681f181b507b34ea87018e8f7a528a",
                              "3361c5df793b4c8448756146a88026ad",
                              "04e820e1ce3a66f47a50ad5074d3ae40",
                              "903092f6488f9ce45a80943923576ab3",
                              "486eaff58293f6441a5c2759c4872f98",
                              "5ab0d42fb68c9e34abae4921822b9d63",
                              "96c9d98b6a9a7c249b6c4572e4977157",
                              "d2f116cfe05fcdd4a94e80143b67046f",
                              "97b991256e43bb140b263c326f690ce2",
                              "c927a8b0cd3f5174f8c0b67cdbfde539",
                              "4093d5a0eb5cae94e909eb1e0e1a6b36",
                              "7bb0c402f7f789d4d9fae8ca87b4c7e2",
                              "1a045f845778dc54db1c2be33a8c3c0a",
                              "c9c56af3b25be3942aa0ffd12f11cf35",
                              "2daf9c5112f16d54ab3cd6904c705c59",
                              "b48674cef2bff5e478a007cf57d8345b",
                              "b0ffc8eaff404f2e9e0a3ee9f4c35486"]),
                LevelList(04,["e7240516af4241b42b2cd819929ea9da",
                              "5d4028eb28a106d4691ed1b92bbb1915",
                              "41c9016596fe1de4faf67425ed691203",
                              "e9cc9378fd6841f48ad59384e79e9953",
                              "20b548bf09bb3ea4bafea78dcb4f3db6",
                              "690c90a82bf2e58449c6b541cb8ea004",
                              "dc6af3b4fd149f841912d8a3ce0983de",
                              "bd5da98859cf2b3418f6d68ea66cabbe",
                              "0087fc2d64b6095478bc7b8d7d512caf",
                              "ecaa0def35b38f949bd1976a6c9539e0",
                              "f2115ac1148256b4ba20788f7e966830",
                              "c66e86905f7606c4eaa5c774f0357b2b",
                              "48a555180a109e545a6e367b1bd3f535"]),
                LevelList(05,["9b93040dad242eb43ac7de6bb6547030",
                              "6d437be73b459594ab103acdcae5b9e2",
                              "93d9d74dac46b9b458d4d2ea7f4b1911",
                              "0a5ddfbcfb3989543ac7c936fc256889",
                              "7c5d556b9a5883048bf030e20daebe31",
                              "7792da00c85b9e042a0fdfc2b66ec9a8",
                              "651110ed4f117a948b41c05c5c7624c0"]),
                LevelList(06,["940a545a665194b48b722c1f9dd78d53",
                              "459e6d5aab080a14499e13b407eb3b85",
                              "f767399367df54645ac620ef7b2062bb",
                              "5d3d689392e4ff740a761ef346815074",
                              "9da37873d79ef0a468f969e4e5116ad2",
                              "f0f761b808dc4b149b08eaf44b99f633",
                              "e15e5e7045fda2244b98c8f010adfe31",
                              "e243740dfdb17a246b116b334ed0b165",
                              "27203d62eb3d4184c9aced94f22e1806",
                              "4cf3d0fae3239ec478f51e86f49161cb",
                              "da1b292d91ba37948893cdbe9ea89e28",
                              "368d7cf2fb69d8a46be5a650f5a5a173"]),
                LevelList(07,["fa08cb49ade3eee42b5fd42bd33cb407",
                              "cc09224ecc9af79449816c45bc5be218",
                              "5da172c4c89f9eb4cbb614f3a67357d3",
                              "03944622fbe04824684ec29ff2cec6a7",
                              "89778dc261fe6094bb2445cb389842d2",
                              "8b02310b46e54de1ae9ba7161831938d"]),
                LevelList(08,["0cea35de4d553cc439ae80b3a8724397",
                              "820170444d4d2a14abc480fcbdb49535",
                              "e788b02f8d21014488067bdd3ba7b325",
                              "df2a0ba6b6dcecf429cbb80a56fee5cf",
                              "80a1a388ee938aa4e90d427ce9a7a3e9"]),
                LevelList(09,["1f173a16120359e41a20fc75bb53d449",
                              "5ee395a2423808c4baf342a4f8395b19",
                              "43740dab07286fe4aa00a6ee104ce7c1",
                              "87a29febd010993419f2a4a9bee11cfc",
                              "9cebb7c46c8d4c55a0e98da9b103fd37"]),
                LevelList(10,[]),
            ];

            List.SetIsMythic(false);
            List.SetSpellsByLevel(SpellsByLevel);
            List.Configure();
        }

        private static SpellLevelList LevelList(int Level, List<string> Spells)
        {
            var LevelList = new SpellLevelList(Level);
            var RefList = new List<BlueprintAbilityReference>();
            foreach (var item in Spells)
            {
                RefList.Add(BlueprintTool.GetRef<BlueprintAbilityReference>(item));
            }
            LevelList.m_Spells = RefList;

            return LevelList;
        }
    }

}

