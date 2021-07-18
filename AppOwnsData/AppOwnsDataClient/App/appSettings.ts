export default class AppSettings {
  public static clientId: string = "d1ab14ec-df06-44ba-8451-fd32244e49a2";
  public static tenant: string = "common";
  // this is WebAPI URL for local development
  public static apiRoot: string = "https://localhost:44302/api/";
  public static apiScopes: string[] = [
    "api://" + AppSettings.clientId + "/Reports.Embed"
  ];
}