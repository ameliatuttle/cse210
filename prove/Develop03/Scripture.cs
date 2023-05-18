using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Scripture
    {
        //This class stores scriptures
        //This class also stores hidden words
        private List<string> scriptures = new List<string>
        {
            "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "Helaman 5:12 And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.",
            "Isaiah 53:3-5 3 He is despised and rejected of men; a man of sorrows, and acquainted with grief: and we hid as it were our faces from him; he was despised, and we esteemed him not. 4 Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted.  5 But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed."
        };
        Random random = new Random();
        public string selectRandomScripture()
        {
            int index = random.Next(scriptures.Count);
            string scripture = $"{scriptures[index]}";
            return scripture;
        }


    }
}