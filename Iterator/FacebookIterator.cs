using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class FacebookIterator : ProfileIterator
    {
        private Facebook _facebook;
        private string _profileId;
        private string _type;
        private int _currentPosition;
        private List<Profile> _cache;

        public FacebookIterator(Facebook facebook, string profileId, string type)
        {
            this._facebook = facebook;
            this._profileId = profileId;
            this._type = type;  
            this._currentPosition = 0;
            this._cache = new List<Profile>();
        }

        private void lazyInit()
        {
            if(_cache.Count == 0)
            {
                Console.WriteLine("Del perfil " + this._profileId);
                Console.WriteLine("Buscar por tipo " + this._type);

                _cache.Add(new Profile("pepe", "pepe@gmail.com"));
                _cache.Add(new Profile("jose", "jose@gmail.com"));
            }
        }

        public Profile? getNext()
        {
            if (hasNext())
            {
                Profile result = this._cache[this._currentPosition];
                this._currentPosition++;
                return result;
            }
            return null; 
        }

        public bool hasNext()
        {
            lazyInit();
            return _currentPosition < _cache.Count;
        }
    }
}
