using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multimedia
{
    public class HuffTree
    {
        public Node Root { get; private set; }

        private Node _nyt; // "not yet transfered"
        private Node[] _nodes;
        private int _nextNum;

        public HuffTree()
        {
            Reset();
        }

        public void Reset()
        {
            Root = new Node { Number = 512 };
            _nyt = Root;
            _nodes = new Node[513];
            _nodes[Root.Number] = Root;
            _nextNum = 511;
        }

        public string Encode(string text)
        {
            var result = new StringBuilder();

            foreach (var c in text)
                result.Append(Encode(c));

            return result.ToString();
        }

        public string Encode(char symbol)
        {
            Node node = Root.FindOrDefault(symbol);

            string code;

            if (node != null)
            {
                code = Root.GetCode(node);
                node.Weight++;
            }
            else
            {
                code = Root.GetNYTCode(string.Empty);
                code += symbol;
                node = AddToNYT(symbol);
            }

            UpdateAll(node.Parent);

            return code;
        }

        public string Decode(string code)
        {
            var result = new StringBuilder();

            int index = 0;
            while (index < code.Length)
            {
                Node node;

                char? symbol = ReadChar(index, code, out int count);
                index += count;

                if (symbol == null)
                {
                    symbol = code[index - 1];
                    node = AddToNYT(symbol.Value);
                }
                else
                {
                    node = Root.FindOrDefault(symbol.Value);
                    node.Weight++;
                }

                UpdateAll(node.Parent);

                result.Append(symbol.Value);
            }

            return result.ToString();
        }

        private char? ReadChar(int index, string code, out int count)
        {
            Node current = Root;
            count = 0;

            while (true)
            {
                count++;

                if (current == _nyt)
                    return null;

                if (current.IsLeaf())
                {
                    count--;
                    return current.Symbol;
                }

                char bit = code[index++];

                if (bit == '0')
                    current = current.Left;
                else if (bit == '1')
                    current = current.Right;
            }
        }

        private Node AddToNYT(char symbol)
        {
            var node = new Node(_nyt, symbol)
            {
                Number = _nextNum
            };
            _nyt.Right = node;
            _nodes[_nextNum--] = node;

            var nyt = new Node(_nyt)
            {
                Number = _nextNum,
                IsNYT = true
            };
            _nyt.IsNYT = false;
            _nyt.Left = nyt;
            _nodes[_nextNum--] = nyt;

            _nyt = nyt;

            return node;
        }

        private void UpdateAll(Node node)
        {
            while (node != null)
            {
                Update(node);
                node = node.Parent;
            }
        }

        private void Update(Node node)
        {
            Node toReplace = NodeToReplace(node.Number, node.Weight);

            if (toReplace != null && node.Parent != toReplace)
                Replace(node, toReplace);

            node.Weight++;
        }

        private Node NodeToReplace(int startIndex, int weight)
        {
            startIndex++;
            Node found = null;

            for (int i = startIndex; i < _nodes.Length; i++)
                if (_nodes[i].Weight == weight)
                    found = _nodes[i];

            return found;
        }

        private void Replace(Node a, Node b)
        {
            ReplaceNumbers(a, b);
            ReplaceSons(a, b);
        }

        private void ReplaceNumbers(Node a, Node b)
        {
            Node temp = _nodes[a.Number];
            _nodes[a.Number] = _nodes[b.Number];
            _nodes[b.Number] = temp;

            int tempNum = a.Number;
            a.Number = b.Number;
            b.Number = tempNum;
        }

        private void ReplaceSons(Node a, Node b)
        {
            bool bIsLeftSon = b.Parent.IsLeftSon(b);

            if (a.Parent.IsLeftSon(a))
                a.Parent.Left = b;
            else
                a.Parent.Right = b;

            Node temp = b.Parent;
            b.Parent = a.Parent;
            a.Parent = temp;

            if (bIsLeftSon)
                temp.Left = a;
            else
                temp.Right = a;
        }
    }
}
