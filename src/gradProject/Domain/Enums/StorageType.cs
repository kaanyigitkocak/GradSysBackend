namespace Domain.Enums;

public enum StorageType
{
    LOCAL_FILE_SYSTEM = 1,        // Yerel Dosya Sistemi
    DATABASE_BLOB = 2,            // Veritabanı Blob
    AZURE_BLOB_STORAGE = 3,       // Azure Blob Storage
    AWS_S3_BUCKET = 4,            // Amazon S3 Bucket
    OTHER_CLOUD_STORAGE = 5       // Diğer Bulut Depolama
} 