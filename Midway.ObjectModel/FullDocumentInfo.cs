using System;
using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ������ ���������� � ���������
    /// �������� � ���� �������, �������, ��������� ��������� � �����.
    /// </summary>
    [DataContract]
    public class FullDocumentInfo
    {
        /// <summary>
        /// ����� ������������ ����� �����������
        /// </summary>
        [DataMember]
        public string From { get; set; }

        /// <summary>
        /// ������������� ������������� �����������
        /// </summary>
        [DataMember]
        public string FromDepartmentId { get; set; }

        /// <summary>
        /// ����� ������������ ����� ����������
        /// </summary>
        [DataMember]
        [Obsolete("��� ����������� �������� �������������")]
        public string To { get; set; }

        /// <summary>
        /// ������������� ������������� ����������
        /// </summary>
        [DataMember]
        [Obsolete("��� ����������� �������� �������������")]
        public string ToDepartmentId { get; set; }

        /// <summary>
        /// ������ ����������� ��������� �� ���������
        /// </summary>
        [DataMember]
        public MessageRecipientWithStatus[] Recipients { get; set; }

        /// <summary>
        /// ���� ��������
        /// </summary>
        [DataMember]
        public DateTime SentDate { get; set; }

        /// <summary>
        /// ������ � ���������
        /// </summary>
        [DataMember]
        public Document Document { get; set; }

        /// <summary>
        /// ������� � ���������
        /// </summary>
        [DataMember]
        public Sign[] Signs { get; set; }

        /// <summary>
        /// ������ ���������������� ��� �������� ��������
        /// </summary>
        [DataMember]
        public DocumentFlowStatus Status { get; set; }

        /// <summary>
        /// ����� ������ �� ���������, ������������� ���������� ������������
        /// </summary>
        [DataMember]
        public UntypedDocumentMultiFlowStatus MultiStatus { get; set; }

        /// <summary>
        /// ��������� ���������, ����������� � ������� ���������
        /// </summary>
        [DataMember]
        public ServiceDocument[] ServiceDocuments { get; set; }

        /// <summary>
        /// ��������� ���������
        /// </summary>
        [DataMember]
        public Document[] RelatedDocuments { get; set; }

        /// TODO ��� ���� �� ����� �����, ���� ��� ���������� ������ ��� ����������� � Docuemnt.Comment?
        /// TODO ����� �� ������������ �������
        /// <summary>
        /// ����������� � ���������
        /// </summary>
        [DataMember]
        public string Comment { get; set; }

        /// <summary>
        /// ������������� ���������
        /// </summary>
        [DataMember]
        public string MessageId { get; set; }

        /// <summary>
        /// ���������� ��������� ����������
        /// </summary>
        [DataMember(IsRequired = false)]
        public int CountRelatedDocuments { get; set; }
    }
}
