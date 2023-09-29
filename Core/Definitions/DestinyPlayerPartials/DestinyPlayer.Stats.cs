namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public int lightLevel;

        public int statAgility;

        public int statResilience;

        public int statRecovery;

        public int statDiscipline;

        public int statIntellect;

        public int statStrength; 

        public void ResetStats()
        {
            lightLevel = 0;

            statAgility = 0;
            statResilience = 0;
            statRecovery = 0;
            statDiscipline = 0;
            statIntellect = 0;
            statStrength = 0;
        }

        private static int StatToLevel(int statInQuestion) => statInQuestion / 10;

        internal void GetLightLevelAverage()
        {
            int totalLight = 0;

            int resultLight = totalLight;

            lightLevel = resultLight;
        }

        public void UpdateStats()
        {
            GetLightLevelAverage();

            UpdateAgility(StatToLevel(statAgility));
            UpdateResillience(StatToLevel(statResilience));
            UpdateRecovery(StatToLevel(statRecovery));
        }

        internal void UpdateAgility(int agilityLevel)
        {
            //include hunter specific "light sprint" passive
            
        }

        internal void UpdateResillience(int resillienceLevel)
        {
            //include titan specific "light ward" passive

            if (resillienceLevel <= 5)
            {
                resilHealthAddition = resillienceLevel;
                resilDamageResist = resillienceLevel / 100;

                if (resillienceLevel == 5)
                    resilDamageResist = 0.08f;
            } 

            if (resillienceLevel > 5 && resillienceLevel < 10)
            {
                resilHealthAddition = resillienceLevel + (resillienceLevel % 5);
                switch (resillienceLevel)
                {
                    case 6:
                        resilDamageResist = 0.14f;
                        break;
                    case 7:
                        resilDamageResist = 0.2f;
                        break;
                    case 8:
                        resilDamageResist = 0.26f;
                        break;
                    case 9:
                        resilDamageResist = 0.32f;
                        break;
                }
            }

            if (resillienceLevel == 10)
            {
                resilHealthAddition = resillienceLevel + (resillienceLevel / 2);
                resilDamageResist = (resillienceLevel / 100) * 4;
            }

            //shove in titan ability stuff here
        }

        internal void UpdateRecovery(int recoveryLevel)
        {
            //include warlock specific "light gaze" passive


        }

        internal static void TriStatCooldownReduction(int cooldownOfStat, int statLevelInQuestion)
        {
            //I should NOT need 3 of these. 
        }
    }
}