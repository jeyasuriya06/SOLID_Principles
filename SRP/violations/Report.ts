
export class Report {
    // report data
}

export class ReportService {

    generateReport(data: string): void {
        // business logic
    }

    saveToDatabase(report: Report): void {
        // persistence logic
    }

    formatForPdf(report: Report): void {
        // presentation logic
    }
}
