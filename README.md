# iptime-rebooter
C# 으로 iptime 공유기를재부팅 시키는 소스

주의:

 <system.net>
    <settings>
      <httpWebRequest useUnsafeHeaderParsing="true" />
    </settings>
  </system.net>
  
  를 App.config 에 무조건 넣어주셔야 잘 작동을합니다. 넣지 않았을 경우 
  서버에서 HTTP 프로토콜 위반이 커밋되었습니다.. Section=ResponseHeader Detail=CR 뒤에는 LF가 와야 합니다.
  라는 오류가 당신을 반깁니다
