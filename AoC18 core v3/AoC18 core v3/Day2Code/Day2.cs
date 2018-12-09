using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18_core_v3.Day2Code
{
    public class Day2
    {

        public const string defaultproblem = "tqzvwnogbarflkpcbdewsmjhxi\r\ntqyvunogzarfckpcbdewsmzhci\r\ntqyvunojzarflkpcbdcwsmyhxi\r\ntqyvunogzarclkpcbdewmmjrxi\r\nhqyvunogzarflkpcbczwsmjhxi\r\ntqyvunogzarflppcudewsmjhei\r\ntqrvunogzarflkpcbpewsmjhdi\r\naqyvunogzarflkpcbdewsjjsxi\r\ntqyvtnogzarflkkcbdewymjhxi\r\ntcyeunogzarfkkpcbdewsmjhxi\r\ntqyvunozzarfvkpcbdewsqjhxi\r\ntkyvuwjgzarflkpcbdewsmjhxi\r\ntqevunogzarflkpnbdkwsmjhxi\r\ntqyvunogqarflkpcppewsmjhxi\r\ntqyvunsgzarflkpcbrewsmjhxk\r\ntqyvunogzarffkpdbnewsmjhxi\r\ntqyvunogvarflkpjbdewsojhxi\r\ntqyvgnogzarflkpfbdswsmjhxi\r\ntqyvunogzarfxkpcbtersmjhxi\r\ntqyvukhgzarflupcbdewsmjhxi\r\ntqyvdnoozyrflkpcbdewsmjhxi\r\ntqyvunogzorflkpcbdewsvjhxd\r\ntqyvunzqzarflkpcbdewxmjhxi\r\ntqykunogzarulkpcbdhwsmjhxi\r\ntqycdnogzarflkpcbdewsmjhxz\r\neqyvunogzarflkpcbdhwqmjhxi\r\ncqyvunogzaralkpcbdewsmjvxi\r\nvqyvunogzarflklcbeewsmjhxi\r\ntqyvunogzarffkpcqdewlmjhxi\r\neqyvunogzarflkpcbdejsmahxi\r\ntqyvunogjarflkocsdewsmjhxi\r\ntqzvunogzanflkpcbdewsmjhxg\r\ntqycunogzarflkpabdewsmkhxi\r\ntqyvunogzarnlkpcbdewimjaxi\r\ntqyvunogzarfzkpcbdepsyjhxi\r\ngqykunogzarelkpcbdewsmjhxi\r\ntqyvuwogzarflkpcbdrwsmjmxi\r\ntqdqunogzarflkpcbdewsvjhxi\r\ntqmvunbgzarflkpcbdewsvjhxi\r\ntqyvunogzarflkpcbheesmjhdi\r\ntqxvunogzarfxkpcbdewsmhhxi\r\ntqyvunogzarflkpabdjosmjhxi\r\ntqyvugogztrflkpybdewsmjhxi\r\ntqyvundgzarflkxcbdewsmjhmi\r\ntqyvunogzurfgkpcbdeksmjhxi\r\ntqyvunokzarfckpcbdewsojhxi\r\ntqyvufobzarflkpcldewsmjhxi\r\ntqyvunogznrflkncbdeusmjhxi\r\ntqyvuncgzarfxkpcmdewsmjhxi\r\noqyvunogzarflkpybdewbmjhxi\r\ntqyvjnogqarfmkpcbdewsmjhxi\r\ntqyvunogzacflkpcidewsmjhwi\r\ntqyvunogzarflkpcbqlwxmjhxi\r\ntqyvunogzarflkpnbhewsvjhxi\r\nvqyiunogzarflkpcbdewsmjhqi\r\ntbyvuncgzarfljpcbdewsmjhxi\r\ntqylunogzarflkpcldexsmjhxi\r\ntqyvulogzarflktcbdewsxjhxi\r\ntqyvmnlgzarflkpcbxewsmjhxi\r\ntqyvunogzartlkpcbdewsmihxp\r\nnqyvunogzarflkpcbdewsmnwxi\r\ntqyvunogzarflkpczdewsmjcxj\r\ntzyvunogzariwkpcbdewsmjhxi\r\ntqyiufogzarflipcbdewsmjhxi\r\noqyvunogzasflkpcbdewsmjhxv\r\ntqyvunoqmarflkpcwdewsmjhxi\r\ntqrvunogzarflkpqbdewnmjhxi\r\ntqyvunogzarmlkocbdewsmjhri\r\ntqyvunogzakflkpcbveasmjhxi\r\ntqyvunorearflkpcbdewsmfhxi\r\ntqynrnogzarflkpcbdewsmjhxp\r\ntiyvueogzaeflkpcbdewsmjhxi\r\ntqyrunogzarflkpccdewbmjhxi\r\ntqtvunogzarflkpcbdewbnjhxi\r\ntqyvfnogzarflhpcbdewsmjqxi\r\ntqyjunoazarflkpcbdewssjhxi\r\ntqyvunxizarflkpcbdewsmjnxi\r\ntqyvunogzarfhkpobdewsmjhai\r\ntqyaunogzanflkpcbxewsmjhxi\r\ntqyvunogzarflkpsbuewsmjmxi\r\ntqyvunogzarzlkwybdewsmjhxi\r\ntqyvunogzarflkpibdawsmhhxi\r\ntqyvunogzarflkycbdewamjwxi\r\ntqyvunourarflkpcbdewsujhxi\r\ntqyvnnogzirflkpcbdewsdjhxi\r\ntayvunogzauflkpcqdewsmjhxi\r\ntqyvunobzfrflkscbdewsmjhxi\r\ntqygvnogzarflkpcbdewsmjnxi\r\noqyvunogzarflkpcbdewsmjsgi\r\ntqyvunokzarflkpcbdewshjhii\r\ntqyvunobzarflkvcbdewskjhxi\r\naqyvunogvarflkpcbdlwsmjhxi\r\ntqyvunogzmrrlbpcbdewsmjhxi\r\ntqyvunggzaqolkpcbdewsmjhxi\r\ntqyvunogqarflkpybdewsmjaxi\r\ntqyvunogzxrflkpcxsewsmjhxi\r\nzqyvunogzarflppcbdewsmjhni\r\ntqvvunogzakslkpcbdewsmjhxi\r\ntqyrunogzarzlkpcbdewsmjtxi\r\ntqyvhnogzarfxkpcbdewqmjhxi\r\ntqyvunogzarflkecbdewgdjhxi\r\ntqyvuwogzerfhkpcbdewsmjhxi\r\ntqmvunogzarflkpcbddwsmdhxi\r\ntqyvunogzarflcqcbdewsmihxi\r\ntqyvunogzarvlkpcbdewsmjmxd\r\ntqyvknogzarfllncbdewsmjhxi\r\ntqyvunogzarflbpcbdrwsajhxi\r\ntqyvunogzarfukpcbddwsmjhii\r\ntqyvuvojzahflkpcbdewsmjhxi\r\ntqyvunogzarfchpcbdeqsmjhxi\r\nwqivueogzarflkpcbdewsmjhxi\r\ntqyvunogzwrflkpcbdewstjhxz\r\ntqyvunogzarfloscbdewsmjhxf\r\ntqfbuiogzarflkpcbdewsmjhxi\r\ntqyvfuogzarflkpcxdewsmjhxi\r\ntqyvunogzarflkpcpdewsmgqxi\r\ntqyvunogzdrflkpcbdewsmqhci\r\ntqyvunogzartlkpcbdewsmjpxj\r\ntqyfunogzarfwkpcbdewsmwhxi\r\ntqyvuntgzarflkjcmdewsmjhxi\r\ntqyvunqfzarflkpckdewsmjhxi\r\nnqyvunogznrflkpcbiewsmjhxi\r\ntqymunobzarflkccbdewsmjhxi\r\ntqyvunogzaoflkprbdewzmjhxi\r\ntqyvunogzaiflkpcvdewbmjhxi\r\ntqwvunogzarfzkpcbdewsmjhxx\r\ntxhvunogzarflkpcbdewsijhxi\r\ntqyeunogkarflkicbdewsmjhxi\r\ntqylunogzarylkpcbdewsmkhxi\r\ntqyvriogzarflkpcbdewsmohxi\r\ntqyvunogzsrflkpcbdeasijhxi\r\ntqyvunogzarflkpcbfewcmjhxh\r\ntqyvunoozvrflkpcbdewimjhxi\r\ntqyvunogqayflkpcidewsmjhxi\r\ntqyounogzarflkpccdewsmjhxg\r\ntqgvunogsarflkpcbdewqmjhxi\r\ntqevunogzarflkpcbmewsmjhpi\r\ntqivunogzarflkgcbdewqmjhxi\r\ntqyuunogzlrflkgcbdewsmjhxi\r\nxqyvbnogznrflkpcbdewsmjhxi\r\ntqyvunogzarfjkpebdewsmnhxi\r\ntqyvvnogzarfskpcxdewsmjhxi\r\nthovunogzarflkpcbdewsmjhvi\r\ntqyvunugzarflkpcpdewsmjrxi\r\ntcyvvnogzarflkdcbdewsmjhxi\r\ntqdfunogzarflkpbbdewsmjhxi\r\ntqyvunogzarflkpcbdnwsejzxi\r\ntqyvunivkarflkpcbdewsmjhxi\r\ntqyvunogzawflopcbdewsmjhmi\r\ntqyvunogzarflkpcbdkwsdjqxi\r\ntqyvunodzarflkpcbdewlmjhei\r\noqyvunoozarflkpcbdemsmjhxi\r\ntiyvunogzarjlkpcbdewfmjhxi\r\ntqrvunogearflkpcbdewsojhxi\r\ntqyvunkgzarflkpcbdcwtmjhxi\r\ntqmvunogzarflkpcbdpwsmjtxi\r\ntqyvunogzarflkpcydeptmjhxi\r\ntqyvunkglarflkpcbdfwsmjhxi\r\ntqyaunogzarflkpcbzeesmjhxi\r\ntqyvunogzarrlkpcbdkwsmjhui\r\ntpyvunogzarflkqcbdewsmjhxd\r\ntvyvunogzarfkkpcbdewsajhxi\r\ngqynunogzarflepcbdewsmjhxi\r\nzqvvunogzarflkpcbdexsmjhxi\r\ntqyyunogzawflkpcbdewsmjhxw\r\ntfyvunogzarflkpcbdewomjrxi\r\ntqyeunogzvrflrpcbdewsmjhxi\r\nnqyvunogzarftkpabdewsmjhxi\r\ntzyvunogzariwkpcbdewmmjhxi\r\ntiyvunogzarflkpcbbewsmjhxa\r\ntqydujoyzarflkpcbdewsmjhxi\r\ntqyvunpgzarflkpcbdeysmjhwi\r\ntqyvunogvarllkpcbdewsmshxi\r\ntqyvunogzbrvlkpcbdewsmjhxp\r\ntcyvueogzarflkacbdewsmjhxi\r\ntqyvunogzrhflkpcbdetsmjhxi\r\ntqavunogzrdflkpcbdewsmjhxi\r\ntqyvunogzjrflkpcbdewstjhki\r\ntqyqunolzarflkpcbdewbmjhxi\r\ntqyvunogzarflkqczdgwsmjhxi\r\ntqyvunogzqrfrkpcbrewsmjhxi\r\ntqyvcnogzhrflkacbdewsmjhxi\r\ntqyvunogzarflkpcbdewsmdhtk\r\ntqyvunoggarftkpcbjewsmjhxi\r\ntvyvunogzarfkkpcpdewsmjhxi\r\ntqyvunogzawflkpcndedsmjhxi\r\ntqyvunogzrrflkpcbdemsmmhxi\r\ntqyvunogzarclkpcbrpwsmjhxi\r\ntryvunogztrflkpcbbewsmjhxi\r\ncqyvundgzarflkpcbdewgmjhxi\r\ntqyvunogzarflktcbkewsmjqxi\r\ntqyvjuogzarflkpcadewsmjhxi\r\ntqyvunogzyrflkpcbbxwsmjhxi\r\nttyvunogzarflkpcbdewsnmhxi\r\ntqyvunogzarflkpcbdeqsmlhki\r\nfqyvugogzarflapcbdewsmjhxi\r\ntqyvunogzartlkppbdewszjhxi\r\ntqyvunfgztrflzpcbdewsmjhxi\r\ntqyvunogmazflkpcbdewsmjhki\r\ntqyvunzdzarflkpcbdewsmjhvi\r\ntqyvunogzarflkpqbzewsujhxi\r\ntqyvunogzarzlkpcbeewymjhxi\r\ntqyounogzarflkpcbdewsnwhxi\r\ntqysunogsaiflkpcbdewsmjhxi\r\ntqdvunogdarflkpcboewsmjhxi\r\nteyvunogzarflkscbdfwsmjhxi\r\ntqyvunoazarflkpcbdvwsmjhpi\r\ntqyvunooearflkpcbdewrmjhxi\r\ntqyvunoszarflnrcbdewsmjhxi\r\ntqyvunogzalflkpcblewsjjhxi\r\nuqlvunkgzarflkpcbdewsmjhxi\r\ntqyvunobzarflkpcidewsmjhvi\r\ntnyvunogzarflkpcbdnwamjhxi\r\ntqyoudogzarflkpcbdgwsmjhxi\r\ntqyvunoggarflkpcbmewsmwhxi\r\ntqykunogzazflkpcbddwsmjhxi\r\ntfyvunogzarflkpcbdewsmjhgo\r\ntqyvunogztrflkpcbdewoojhxi\r\ntqyvunogzarflkpcbdewbmjoni\r\ntmyvunogzalflkpabdewsmjhxi\r\ntqyvunogzarflkpbbvewqmjhxi\r\ntqyvunofzarflkpcwdexsmjhxi\r\ntayvunogzasflkpcbdewsmhhxi\r\ntqyvlnogzarflkpcbdewsmjwxd\r\ntvyvunogzarflkpcbdewhmjrxi\r\ntqyvunogzarplkpcsdewsmihxi\r\ntqyvunogzarplklcbdewsmjtxi\r\nrqbvunogzarhlkpcbdewsmjhxi\r\ntqyvuxogzarftkpcbdewsmthxi\r\ntqtvunogzarfikpczdewsmjhxi\r\ntqyvunwgzarflkpcbdewsmjxxk\r\ntqygunogzarzlkpnbdewsmjhxi\r\ntqyvunogzarjlkpcbdbwswjhxi\r\ntqyvunogzalfnkpcbdewsmjhxf\r\ntqyucuogzarflkpcbdewsmjhxi\r\ntzyvunogzvrflkpcbdewsmjaxi\r\ntjyvunlgzarflkpcbdewgmjhxi\r\ntqyvcnogzarklkpcbdewsmjhfi\r\ntqyvunogzaaflkpsbaewsmjhxi\r\ntsyvunogzarflkpctdewsmbhxi\r\ntqyeunbgzarflkpcbdewrmjhxi\r\ntqyvunogzcrflqpcbdeismjhxi\r\neqylunogzarflkpcbdewsmjhxy\r\ntqyvundgzarflkpcbdewmmnhxi\r\ntzyvunogzarflkpcndewsmjhxb\r\ntkyvunogzxrflkpcbdewfmjhxi\r\ntqyvunogzarflkxcbdzwsmjfxi\r\nkqavunogzarflkycbdewsmjhxi\r\ntqyvunogzarjlkpcbdxwkmjhxi\r\ntqyvinogzarfqkpcbdewsmjpxi";
        //we'll be getting strings of variable length.
        //we need to count instances of letters for 2 or 3 occurences.
        //If there is a pair of letters (not in sequence) then that flags.
        //If there is a trio of letters (not in sequence) that flags.
        //more than one occurence does not increase the flags.

        //two code options - RegExs or array searching.
        //I feel Regexs are the correct option, but arrays are the known quantity
        //Having dabbled with regexs, it's too advanced an option to go all in on.
        public static void checkstring(string sentence)
        {
            int twos = 0;
            int threes = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                var letter = sentence.Substring(i, 1);
                var result = checkforletter(letter, sentence);

                if (result == 2) { twos++; }
                if (result == 3) { threes++; }
            }
        }


        public static int checkforletter(string letter, string sentence)
        {
            var found = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence.Substring(i,1) == letter)
                {
                    found++;
                }
            }

            return found;
        }

    }
}
