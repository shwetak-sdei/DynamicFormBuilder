export class DocumentModel {
    id: number;
    documentName: string;
    description: string;
    displayOrder?: number;
    documenttypeId: number;
    totalRecords: number;
    benchmarkRangeModel: BenchmarkRangeModel[];
  }
  
  export class BenchmarkRangeModel {
    id?: number = 0;
    benchmarkId?: number = null;
    minRange?: number = null;
    maxRange?: number = null;
    questionnaireId?: number;
  }
export class CategoryModel {
    id: number;
    categoryName: string;
    description: string;
    totalRecords: number;
}
export class CategoryCodeModel {
    id: number = null;
    categoryId: number;
    codeName: string;
    description: string;
    displayOrder: number;
    score: number;
    totalRecords: number;
}
export class SectionModel {
    id: number;
    documentId: number;
    sectionName: string;
    displayOrder: number;
    totalRecords: number;
}
export class SectionItemModel {
    sectionItems: SectionItem[];
    codes: Code[];
    answer: Answer[];
    id: number;
    documentId: number;
    sectionId: number;
    itemtype: number;
    itemLabel: string;
    displayOrder: number;
    categoryId: number;
    isNumber:boolean;
    isMandatory:boolean;
    placeholder:string;
}
export class SectionItem {
    id: number;
    categoryId: number;
    sectionName: string;
    inputType: string;
    question: string;
    displayOrder: number;
    totalRecords: number;
    isNumber:boolean;
    isMandatory:boolean;
    placeholder:string;
}
export class Code {
    id: number;
    categoryId: number;
    option: string;
    displayOrder: number;
}
export class Answer {
    id: number;
    sectionItemId: number;
    answerId: number;
    textAnswer: string;
}
export class PatientDocumentModel {
    id: number;
    patientDocumentId: number;
    documentId:number;
    documentName: string;
    patientName: string;
    patientId: number;
    assignedBy: string;
    status: string;
    createdDate: Date;
    totalRecords: number;
}