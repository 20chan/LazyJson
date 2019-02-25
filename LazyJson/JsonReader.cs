using System;
using System.IO;

namespace LazyJson {
    public class JsonReader : IDisposable {
        private StreamReader reader;
        public JsonReader(Stream stream) {
            reader = new StreamReader(stream);
        }

        public void Dispose() {
            reader?.Dispose();
        }
        
        
    }
}