import { config } from "../apiConfig";
import ResourceList from "../Models/ResourseListModel";

const GetResourceList = async (): Promise<ResourceList> => {
  const result: Response = await fetch(`${config.reqresUrl}/api/unknown`);
  const body = await result.json();

  return body as ResourceList;
};

export default GetResourceList;
