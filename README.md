# alidns
阿里云的alidns的C#版本，修复官方的一个无法获取Value值的bug
* 注意，如果需要调用这个sdk，需要依赖官方的[aliyun-net-sdk-core](https://github.com/aliyun/aliyun-openapi-net-sdk)
* 使用SDK你需要去申请[AccessKey](https://ak-console.aliyun.com/#/accesskey)
* API的功能简介[看这里](https://help.aliyun.com/document_detail/29740.html?spm=5176.doc29739.6.129.jtR9JZ)
调用示例：
```
IAcsClient client = null;
string RegionId = "cn-hangzhou";//固定为"cn-hangzhou"
string AccessKeyId = keyJson.ID;//你的AccessKeyID
string AccessKeySecret = keyJson.Secret;//你的AccessKeySecret

var profile = DefaultProfile.GetProfile(RegionId, AccessKeyId, AccessKeySecret);

client = new DefaultAcsClient(profile);

DescribeDomainRecordInfoRequest request = new DescribeDomainRecordInfoRequest();//创建一个request，不同的功能用不同的request
DescribeDomainRecordInfoResponse response;//创建一个response，不同功能返回的response不同
request.RecordId = recordId;//设置request的参数，不同的功能参数不同
response = client.GetAcsResponse<DescribeDomainRecordInfoResponse>(request);

return response.Value;//返回你要的值，不同功能返回的值不同，详见API文档
```
