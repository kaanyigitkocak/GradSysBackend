using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class TranscriptData : Entity<Guid> // transcriptDataId olacak primary key
{
    // transcriptDataId (Guid, Primary Key) -> Id
    public Guid StudentUserId { get; set; } // User with StudentProfile
    public Guid SourceFileAttachmentId { get; set; } // Document.documentType = UPLOADED_TRANSCRIPT_JSON -> FileAttachment olacak
    public DateTime ParsingDate { get; set; } // Timestamp
    public decimal ParsedGpa { get; set; }
    public int ParsedEcts { get; set; }
    public bool IsValidForProcessing { get; set; } = false;

    // Navigation Properties
    public virtual User StudentUser { get; set; }
    public virtual FileAttachment SourceFileAttachment { get; set; } // Document -> FileAttachment

    public TranscriptData() { }

    public TranscriptData(Guid id, Guid studentUserId, Guid sourceFileAttachmentId, DateTime parsingDate, decimal parsedGpa, int parsedEcts, bool isValidForProcessing = false)
    {
        Id = id;
        StudentUserId = studentUserId;
        SourceFileAttachmentId = sourceFileAttachmentId;
        ParsingDate = parsingDate;
        ParsedGpa = parsedGpa;
        ParsedEcts = parsedEcts;
        IsValidForProcessing = isValidForProcessing;
    }
} 