
#### Ed-Fi ODS / API for Suite 3 v7.3

```powershell
java  -Xms1g -Xmx4g -jar openApi-codegen-cli.jar generate -g csharp `
  -i https://api.ed-fi.org/v7.3/api/metadata/data/v3/ed-fi/swagger.json `
  --api-package Apis.All --model-package Models.All -o ./EdFi.OdsApi.Sdk.73 `
  --additional-properties packageName=EdFi.OdsApi.Sdk.73,targetFramework=net8.0,netCoreProjectFile=true `
  --global-property modelTests=false --global-property apiTests=false --skip-validate-spec
```

#### Ed-Fi ODS / API for Suite 3 v7.2

```powershell
java  -Xms1g -Xmx4g -jar openApi-codegen-cli.jar generate -g csharp `
  -i https://api.ed-fi.org/v7.2/api/metadata/data/v3/ed-fi/swagger.json `
  --api-package Apis.All --model-package Models.All -o ./EdFi.OdsApi.Sdk.72 `
  --additional-properties packageName=EdFi.OdsApi.Sdk.72,targetFramework=net8.0,netCoreProjectFile=true `
  --global-property modelTests=false --global-property apiTests=false --skip-validate-spec
```

#### Ed-Fi ODS / API for Suite 3 v7.1

```powershell
java  -Xms1g -Xmx4g -jar openApi-codegen-cli.jar generate -g csharp `
  -i https://api.ed-fi.org/v7.1/api/metadata/data/v3/ed-fi/swagger.json `
  --api-package Apis.All --model-package Models.All -o ./EdFi.OdsApi.Sdk.71 `
  --additional-properties packageName=EdFi.OdsApi.Sdk.71,targetFramework=net8.0,netCoreProjectFile=true `
  --global-property modelTests=false --global-property apiTests=false --skip-validate-spec
```

#### Ed-Fi ODS / API for Suite 3 v6.2

```powershell
java  -Xms1g -Xmx4g -jar openApi-codegen-cli.jar generate -g csharp `
  -i https://api.ed-fi.org/v6.2/api/metadata/data/v3/ed-fi/swagger.json `
  --api-package Apis.All --model-package Models.All -o ./EdFi.OdsApi.Sdk.62 `
  --additional-properties packageName=EdFi.OdsApi.Sdk.62,targetFramework=net8.0,netCoreProjectFile=true `
  --global-property modelTests=false --global-property apiTests=false --skip-validate-spec
```

#### Ed-Fi ODS / API for Suite 3 v5.4

```powershell
java  -Xms1g -Xmx4g -jar openApi-codegen-cli.jar generate -g csharp `
  -i https://api.ed-fi.org/v5.4/api/metadata/data/v3/ed-fi/swagger.json `
  --api-package Apis.All --model-package Models.All -o ./EdFi.OdsApi.Sdk.54 `
  --additional-properties packageName=EdFi.OdsApi.Sdk.54,targetFramework=net8.0,netCoreProjectFile=true `
  --global-property modelTests=false --global-property apiTests=false --skip-validate-spec
```



