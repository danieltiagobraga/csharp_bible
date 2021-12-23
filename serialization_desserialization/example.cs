/*
    Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, 
    a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed. 
    
    The reverse process is called deserialization.

    

*/
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization_desserialization
{
    [Serializable]

    class Customer {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        private Customer() {}

        public Customer(string name, string phoneNumber) {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public MemoryStream Serialize() {
            MemoryStream stream = new MemoryStream();
            var binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, this);

            return stream;
        }
    }
}
