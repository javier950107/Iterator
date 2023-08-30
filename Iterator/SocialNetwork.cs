using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal interface SocialNetwork
    {
        ProfileIterator createFriendsIterator(string profileEmail);
        ProfileIterator createCoworkersIterator(string profileEmail);
    }
}
