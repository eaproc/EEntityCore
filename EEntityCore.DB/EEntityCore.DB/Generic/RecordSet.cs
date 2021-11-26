using System.Linq;

namespace EEntityCore.DB.Genric
{

    /// <summary>
    /// Helps to Navigate a Record Set
    /// </summary>
    /// <remarks></remarks>
    public sealed class RecordSet<T>
    {

        // REM Currently Delete will not be implemented
        // REM Just Load Data
        // REM Navigate to and From

        // REM When a Data is Loaded, specify current index should be kept or move to first if there is




        #region Constructors


        public RecordSet(T[] DBCursorList)
        {
            this.DBCursorList = DBCursorList;
            moveFirst();
        }



        #endregion


        #region Properties


        public T DBCursor
        {
            get
            {
                if (CurrentIndex >= 0 && hasRecords && CurrentIndex < DBCursorList.Count())
                {
                    return DBCursorList[CurrentIndex];
                }

                return default;
            }
        }

        private int CurrentIndex = -1;
        private T[] DBCursorList = null;

        public bool hasRecords
        {
            get
            {
                return DBCursorList is object && DBCursorList.Count() > 0;
            }
        }

        public bool hasNext
        {
            get
            {
                return hasRecords && CurrentIndex < DBCursorList.Count() - 1;
            }
        }

        public bool hasPrevious
        {
            get
            {
                return hasRecords && CurrentIndex > 0;
            }
        }

        /// <summary>
        /// Indicate it has reach eof of record
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool EOF
        {
            get
            {
                if (DBCursorList is null)
                    return true;
                return CurrentIndex + 1 > DBCursorList.Count();
            }
        }


        /// <summary>
        /// Indicate Position is at -1 index
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool BOF
        {
            get
            {
                return CurrentIndex == -1;
            }
        }

        /// <summary>
        /// Displays the Absolute index of this current record. Like 1 of 4
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int AbsoluteIndex
        {
            get
            {
                // REM since there can be minimum of the Lowest digit
                // REM Else you have 0 of 0
                if (!EOF)
                {
                    return CurrentIndex + 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int TotalRecords
        {
            get
            {
                if (hasRecords)
                    return DBCursorList.Count();
                return 0;
            }
        }

        #endregion



        #region Methods

        private void NullPointer()
        {
            CurrentIndex = -1;
        }

        public T moveFirst()
        {
            NullPointer();
            if (hasRecords)
                CurrentIndex = 0;
            return DBCursor;
        }

        public T movePrevious()
        {
            int __CurrentIndex = CurrentIndex;
            if (hasRecords & __CurrentIndex > 0)
            {
                if (EOF)
                {
                    CurrentIndex = DBCursorList.Count() - 1;
                }
                else
                {
                    CurrentIndex -= 1;
                }
            }
            else
            {
                NullPointer();
            } // REM No Record at all

            return DBCursor;
        }

        public T moveNext()
        {
            // REM If I do it like this .. It will return the Cursor to the BOF when it reaches EOF
            // 'If Me.hasNext Then
            // '    Me.CurrentIndex += 1
            // 'Else
            // '    Me.NullPointer()
            // 'End If
            CurrentIndex += 1;
            return DBCursor;
        }

        public T moveLast()
        {
            NullPointer();
            if (hasRecords)
                CurrentIndex = DBCursorList.Count() - 1;
            return DBCursor;
        }

        private T gotoRecord(int index)
        {
            NullPointer();
            if (hasRecords && index < DBCursorList.Count())
                CurrentIndex = index;
            return DBCursor;
        }

        public void reloadData(T[] DBCursorList, bool maintainCurrentIndex = false)
        {
            int __currentIndex = CurrentIndex;
            this.DBCursorList = DBCursorList;
            if (maintainCurrentIndex)
                gotoRecord(__currentIndex);
        }

        #endregion




    }
}