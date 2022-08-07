import DataResourse from "./DataResourceModel";

interface ResourseList {
  page: string;
  per_page: number;
  total: number;
  total_pages: number;
  data: DataResourse[];
}

export default ResourseList;
