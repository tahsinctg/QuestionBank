﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace QuestionBank
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class QuestionBank_NizamEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new QuestionBank_NizamEntities object using the connection string found in the 'QuestionBank_NizamEntities' section of the application configuration file.
        /// </summary>
        public QuestionBank_NizamEntities() : base("name=QuestionBank_NizamEntities", "QuestionBank_NizamEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new QuestionBank_NizamEntities object.
        /// </summary>
        public QuestionBank_NizamEntities(string connectionString) : base(connectionString, "QuestionBank_NizamEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new QuestionBank_NizamEntities object.
        /// </summary>
        public QuestionBank_NizamEntities(EntityConnection connection) : base(connection, "QuestionBank_NizamEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<question> questions
        {
            get
            {
                if ((_questions == null))
                {
                    _questions = base.CreateObjectSet<question>("questions");
                }
                return _questions;
            }
        }
        private ObjectSet<question> _questions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<subject> subjects
        {
            get
            {
                if ((_subjects == null))
                {
                    _subjects = base.CreateObjectSet<subject>("subjects");
                }
                return _subjects;
            }
        }
        private ObjectSet<subject> _subjects;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<topic> topics
        {
            get
            {
                if ((_topics == null))
                {
                    _topics = base.CreateObjectSet<topic>("topics");
                }
                return _topics;
            }
        }
        private ObjectSet<topic> _topics;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the questions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToquestions(question question)
        {
            base.AddObject("questions", question);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the subjects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosubjects(subject subject)
        {
            base.AddObject("subjects", subject);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the topics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotopics(topic topic)
        {
            base.AddObject("topics", topic);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="QuestionBank_NizamModel", Name="question")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class question : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new question object.
        /// </summary>
        /// <param name="question_code">Initial value of the question_code property.</param>
        public static question Createquestion(global::System.String question_code)
        {
            question question = new question();
            question.question_code = question_code;
            return question;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String question_code
        {
            get
            {
                return _question_code;
            }
            set
            {
                if (_question_code != value)
                {
                    Onquestion_codeChanging(value);
                    ReportPropertyChanging("question_code");
                    _question_code = StructuralObject.SetValidValue(value, false, "question_code");
                    ReportPropertyChanged("question_code");
                    Onquestion_codeChanged();
                }
            }
        }
        private global::System.String _question_code;
        partial void Onquestion_codeChanging(global::System.String value);
        partial void Onquestion_codeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String topics_code
        {
            get
            {
                return _topics_code;
            }
            set
            {
                Ontopics_codeChanging(value);
                ReportPropertyChanging("topics_code");
                _topics_code = StructuralObject.SetValidValue(value, true, "topics_code");
                ReportPropertyChanged("topics_code");
                Ontopics_codeChanged();
            }
        }
        private global::System.String _topics_code;
        partial void Ontopics_codeChanging(global::System.String value);
        partial void Ontopics_codeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String question1
        {
            get
            {
                return _question1;
            }
            set
            {
                Onquestion1Changing(value);
                ReportPropertyChanging("question1");
                _question1 = StructuralObject.SetValidValue(value, true, "question1");
                ReportPropertyChanged("question1");
                Onquestion1Changed();
            }
        }
        private global::System.String _question1;
        partial void Onquestion1Changing(global::System.String value);
        partial void Onquestion1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String correct_ans
        {
            get
            {
                return _correct_ans;
            }
            set
            {
                Oncorrect_ansChanging(value);
                ReportPropertyChanging("correct_ans");
                _correct_ans = StructuralObject.SetValidValue(value, true, "correct_ans");
                ReportPropertyChanged("correct_ans");
                Oncorrect_ansChanged();
            }
        }
        private global::System.String _correct_ans;
        partial void Oncorrect_ansChanging(global::System.String value);
        partial void Oncorrect_ansChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String wrong_answer1
        {
            get
            {
                return _wrong_answer1;
            }
            set
            {
                Onwrong_answer1Changing(value);
                ReportPropertyChanging("wrong_answer1");
                _wrong_answer1 = StructuralObject.SetValidValue(value, true, "wrong_answer1");
                ReportPropertyChanged("wrong_answer1");
                Onwrong_answer1Changed();
            }
        }
        private global::System.String _wrong_answer1;
        partial void Onwrong_answer1Changing(global::System.String value);
        partial void Onwrong_answer1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String wrong_answer2
        {
            get
            {
                return _wrong_answer2;
            }
            set
            {
                Onwrong_answer2Changing(value);
                ReportPropertyChanging("wrong_answer2");
                _wrong_answer2 = StructuralObject.SetValidValue(value, true, "wrong_answer2");
                ReportPropertyChanged("wrong_answer2");
                Onwrong_answer2Changed();
            }
        }
        private global::System.String _wrong_answer2;
        partial void Onwrong_answer2Changing(global::System.String value);
        partial void Onwrong_answer2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String wrong_answer3
        {
            get
            {
                return _wrong_answer3;
            }
            set
            {
                Onwrong_answer3Changing(value);
                ReportPropertyChanging("wrong_answer3");
                _wrong_answer3 = StructuralObject.SetValidValue(value, true, "wrong_answer3");
                ReportPropertyChanged("wrong_answer3");
                Onwrong_answer3Changed();
            }
        }
        private global::System.String _wrong_answer3;
        partial void Onwrong_answer3Changing(global::System.String value);
        partial void Onwrong_answer3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String difficulty_level
        {
            get
            {
                return _difficulty_level;
            }
            set
            {
                Ondifficulty_levelChanging(value);
                ReportPropertyChanging("difficulty_level");
                _difficulty_level = StructuralObject.SetValidValue(value, true, "difficulty_level");
                ReportPropertyChanged("difficulty_level");
                Ondifficulty_levelChanged();
            }
        }
        private global::System.String _difficulty_level;
        partial void Ondifficulty_levelChanging(global::System.String value);
        partial void Ondifficulty_levelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String estimated_time
        {
            get
            {
                return _estimated_time;
            }
            set
            {
                Onestimated_timeChanging(value);
                ReportPropertyChanging("estimated_time");
                _estimated_time = StructuralObject.SetValidValue(value, true, "estimated_time");
                ReportPropertyChanged("estimated_time");
                Onestimated_timeChanged();
            }
        }
        private global::System.String _estimated_time;
        partial void Onestimated_timeChanging(global::System.String value);
        partial void Onestimated_timeChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="QuestionBank_NizamModel", Name="subject")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class subject : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new subject object.
        /// </summary>
        /// <param name="subject_code">Initial value of the subject_code property.</param>
        public static subject Createsubject(global::System.String subject_code)
        {
            subject subject = new subject();
            subject.subject_code = subject_code;
            return subject;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String subject_code
        {
            get
            {
                return _subject_code;
            }
            set
            {
                if (_subject_code != value)
                {
                    Onsubject_codeChanging(value);
                    ReportPropertyChanging("subject_code");
                    _subject_code = StructuralObject.SetValidValue(value, false, "subject_code");
                    ReportPropertyChanged("subject_code");
                    Onsubject_codeChanged();
                }
            }
        }
        private global::System.String _subject_code;
        partial void Onsubject_codeChanging(global::System.String value);
        partial void Onsubject_codeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String subject_name
        {
            get
            {
                return _subject_name;
            }
            set
            {
                Onsubject_nameChanging(value);
                ReportPropertyChanging("subject_name");
                _subject_name = StructuralObject.SetValidValue(value, true, "subject_name");
                ReportPropertyChanged("subject_name");
                Onsubject_nameChanged();
            }
        }
        private global::System.String _subject_name;
        partial void Onsubject_nameChanging(global::System.String value);
        partial void Onsubject_nameChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="QuestionBank_NizamModel", Name="topic")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class topic : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new topic object.
        /// </summary>
        /// <param name="topics_code">Initial value of the topics_code property.</param>
        public static topic Createtopic(global::System.String topics_code)
        {
            topic topic = new topic();
            topic.topics_code = topics_code;
            return topic;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String topics_code
        {
            get
            {
                return _topics_code;
            }
            set
            {
                if (_topics_code != value)
                {
                    Ontopics_codeChanging(value);
                    ReportPropertyChanging("topics_code");
                    _topics_code = StructuralObject.SetValidValue(value, false, "topics_code");
                    ReportPropertyChanged("topics_code");
                    Ontopics_codeChanged();
                }
            }
        }
        private global::System.String _topics_code;
        partial void Ontopics_codeChanging(global::System.String value);
        partial void Ontopics_codeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String subject_code
        {
            get
            {
                return _subject_code;
            }
            set
            {
                Onsubject_codeChanging(value);
                ReportPropertyChanging("subject_code");
                _subject_code = StructuralObject.SetValidValue(value, true, "subject_code");
                ReportPropertyChanged("subject_code");
                Onsubject_codeChanged();
            }
        }
        private global::System.String _subject_code;
        partial void Onsubject_codeChanging(global::System.String value);
        partial void Onsubject_codeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String topics_name
        {
            get
            {
                return _topics_name;
            }
            set
            {
                Ontopics_nameChanging(value);
                ReportPropertyChanging("topics_name");
                _topics_name = StructuralObject.SetValidValue(value, true, "topics_name");
                ReportPropertyChanged("topics_name");
                Ontopics_nameChanged();
            }
        }
        private global::System.String _topics_name;
        partial void Ontopics_nameChanging(global::System.String value);
        partial void Ontopics_nameChanged();

        #endregion

    }

    #endregion

}
