using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class SocialSpammer
    {
        public void send(ProfileIterator iterator, string message)
        {
            while(iterator.hasNext())
            {
                Profile profile = iterator.getNext();
                Console.WriteLine("Send message to " + profile.getEmail() + " message: " + message);
            }
        }
    }
}
