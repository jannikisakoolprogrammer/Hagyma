﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagyma
{
    public delegate void MenuItemClicked(
        object _sender,
        EventArgs _e);

    public delegate void ButtonClicked(
        object _sender,
        EventArgs _eventArgs);

    public delegate void FormClosed(
        object _sender,
        FormClosedEventArgs _e);

    public delegate void TreeNodeClicked(
        object _sender,
        TreeNodeMouseClickEventArgs _e);

    public delegate void TreeNodeClickedBefore(
        object _sender,
        TreeViewCancelEventArgs _e);

    public delegate void TreeNodeClickedAfter(
        object _sender,
        TreeViewEventArgs _e);

    public delegate void KeyDown(
        object _sender,
        KeyEventArgs _e);
}