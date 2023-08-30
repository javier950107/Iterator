using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Facebook : SocialNetwork
    {
        public ProfileIterator createCoworkersIterator(string profileEmail)
        {
            return new FacebookIterator(this, profileEmail, "coworkers");
        }

        public ProfileIterator createFriendsIterator(string profileEmail)
        {
            return new FacebookIterator(this, profileEmail, "friends");
        }
    }
}
