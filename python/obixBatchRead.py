import requests
from requests.auth import HTTPBasicAuth
from xml.dom.minidom import parseString

url = "http://127.0.0.1/obix/batch/"

payload = """
<list is="obix:BatchIn"> 
  <uri is="obix:Read" val="/obix/config/data/Ramp1/out/value/" />
  <uri is="obix:Read" val="/obix/config/data/Ramp2/out/value/" />
  <uri is="obix:Read" val="/obix/config/data/Ramp3/out/value/" />
</list>
""";

response = requests.request("POST", url, data=payload, auth=('obix','Admin12345'))
#print(response.text)

#解析 xml：(response.text)
doc = parseString(response.text)
collection = doc.documentElement
data = collection.getElementsByTagName("real")
if len(data)==3:
  print("Ramp1: " + data[0].getAttribute("display"));
  print("Ramp2: " + data[1].getAttribute("display"));
  print("Ramp3: " + data[2].getAttribute("display"));
