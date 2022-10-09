using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CracksMan.Models;
using CracksMan.Models.Enums;

namespace CracksMan.Infrastructure
{
    public class Table : IEnumerable<Handle>
    {
        public int CountColumns { get; private set; }
        public int CountLines  { get; private set; }
        public int CountUpHandle { get; private set; }
        public bool AllUnLock { get { return (CountColumns * CountLines) == CountUpHandle; } }
        public event EventHandler<ArgumentControlHandle> OnChangeElementState;
        public event EventHandler<ArgumentControlHandle> OnClickElementHandle;
        private List<List<Handle>> _matrix;
        public Table(int columns,int lines)
        {
            if (!IsValid(columns, lines))
            {
                throw new ArgumentException("Rows and columns must be greater than zero.");
            }
            _matrix = new List<List<Handle>>();
            CountColumns = columns;
            CountLines = lines;
            CountUpHandle = columns*lines;
            FillTable(columns, lines);
        }

        public void ColumnsCallBack(int column, Action<Handle> callBack, params Vector2[] block)
        {
            if (!(CountColumns>= column && column > 0))
            {
                throw new ArgumentException("Wrong argument column.");
            }
            foreach (var item in _matrix.Where(x=> !block.Contains(x[column-1].Vector2)))
            {
                callBack?.Invoke(item[column-1]);
            }
        }

        public void LineCallBack(int line, Action<Handle> callBack, params Vector2[] block)
        {
            if (!(CountLines >= line && line > 0))
            {
                throw new ArgumentException("Wrong argument lines.");
            }
            foreach (var item in _matrix[line-1].Where(x => !block.Contains(x.Vector2)))
            {
                callBack?.Invoke(item);
            }
        }

        private void HandlerChangeState(object obj, ArgumentControlHandle argumentControlHandle )
        {
            if (argumentControlHandle.Position == Position.Up)
            {
                CountUpHandle++;
            }
            else if (argumentControlHandle.Position == Position.Down)
            {
                CountUpHandle--;
            }
            OnChangeElementState?.Invoke(obj, argumentControlHandle);

            if (argumentControlHandle.IsClick)
            {

               // MessageBox.Show($"Х - {argumentControlHandle.Vector2.X} Y - {argumentControlHandle.Vector2.Y} state - {((Handle)obj).GetState()}");
                OnClickElementHandle?.Invoke(obj, argumentControlHandle);
            }
            
        }

        private bool IsValid(int columns, int lines)
        {
            bool result = (columns > 0) && (lines > 0);
            return result;
        }
        
        private void FillTable(int columns, int lines)
        {
            for (int i = 1;i <= lines; i++)
            {
                List<Handle> line = new List<Handle>();
                for (int j = 1; j <= columns; j++)
                {
                    Handle handle = new Handle(new Vector2(j, i));
                    handle.OnChangeState += HandlerChangeState;
                    line.Add(handle);
                }
                _matrix.Add(line);
            }
        }

        public IEnumerator<Handle> GetEnumerator()
        {
            foreach (var item in _matrix.SelectMany(x=>x))
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Handle this[int x, int y] => _matrix[y][x];
    }
}
