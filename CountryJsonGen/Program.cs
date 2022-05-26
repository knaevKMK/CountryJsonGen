using IO;
using Models;

string readTempFrom = @"C:\Users\master\Desktop\GitHub\JsonGen\CountryJsonGen\CountryJsonGen\Temp.json";
string readCachFrom = @"C:\Users\master\Desktop\GitHub\JsonGen\CountryJsonGen\CountryJsonGen\Cach.json";

string writeTo = @"C:\Users\master\Desktop\GitHub\JsonGen\CountryJsonGen\CountryJsonGen\Result.json";

List<Temp> readFrom = ReaderFile.Read<Temp>(readTempFrom);
List<Cach> readCach = ReaderFile.Read<Cach>(readCachFrom);

readCach
    .ForEach(x=>x.FlagSymbol= readFrom.Where(y=>y.Name.Common==x.Name).Select(y=>y.FlagSymbol).FirstOrDefault());

WriterFile.Write<Cach>(writeTo, readCach);