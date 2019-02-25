# LazyJson

## Concepts

스트림으로부터 비동기적으로 레이지하게 데이터를 읽는다

```csharp
var req = HttpWebRequest.Create(url) as HttpWebRequest;
var w = req.GetResponse();
var s = w.GetResponseStream();

var reader = new LazyJsonReader(s);
var data = reader[10]["key"];
Console.WriteLine(data);
```

원본 데이터를 통째로 문자열 혹은 바이트 배열로 받으면 Span-Like 한 데이터로 적당히 넘겨주면 성능면이나 메모리면에서 걱정할 필요가 없을텐데 스트림에서 바이트씩 읽어서 파싱을 하는거면 메모리 관리를 어떻게 해야할지 모르겠다

렉서를 중간에 멈출 수 있다 렉서가 필요한데까지만 긁다가 멈췄다가 다시 일하고 멈추고를 반복할 수 있어야 한다

근데 정말 문자열 메모리 어떻게 처리하지


JsonSerializer 가 이미 충분히 레이지한것 같다 그렇다면 이거 그냥 래퍼 클래스로 만들어서 레이지 친화적인 인터페이스를 만들면 되지 않을까

굳이 만들 필요가 없던걸로 밝혀졌다
