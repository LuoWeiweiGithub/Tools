" ****** Vundle setting *******
set nocompatible              " be iMproved, required
filetype off                  " required

" set the runtime path to include Vundle and initialize
set rtp+=~/.vim/bundle/Vundle.vim
call vundle#begin()
" alternatively, pass a path where Vundle should install plugins
"call vundle#begin('~/some/path/here')

" let Vundle manage Vundle, required
Plugin 'VundleVim/Vundle.vim'

" The following are examples of different formats supported.
" Keep Plugin commands between vundle#begin/end.
" plugin on GitHub repo
Plugin 'tpope/vim-fugitive'
" plugin from http://vim-scripts.org/vim/scripts.html
" Plugin 'L9'
" Git plugin not hosted on GitHub
Plugin 'git://git.wincent.com/command-t.git'
" git repos on your local machine (i.e. when working on your own plugin)
" Plugin 'file://~/to/plugin'
" The sparkup vim script is in a subdirectory of this repo called vim.
" Pass the path to set the runtimepath properly.
Plugin 'rstacruz/sparkup', {'rtp': 'vim/'}
" Install L9 and avoid a Naming conflict if you've already installed a
" different version somewhere else.
" Plugin 'ascenator/L9', {'name': 'newL9'}

" All of your Plugins must be added before the following line
call vundle#end()            " required
filetype plugin indent on    " required
" To ignore plugin indent changes, instead use:
" filetype plugin on
"
" Brief help
" :PluginList       - lists configured plugins
" :PluginInstall    - installs plugins; append `!` to update or just :PluginUpdate
" :PluginSearch foo - searches for foo; append `!` to refresh local cache
" :PluginClean      - confirms removal of unused plugins; append `!` to auto-approve removal
"
" see :h vundle for more details or wiki for FAQ
" Put your non-Plugin stuff after this line

" *******************************************************************
" display
set number
set tabstop=4		" number of spaces that a <TAB> in the file counts for
set softtabstop=4	" number of spaces that a <TAB> counts for while performing editng opearions.
set shiftwidth=4	" number of spaces to used for autoidenting >
set ruler			" show the current line number and column number
set autoindent		" auto ident
set showcmd
set autoindent
set nobackup
set list
set listchars=tab:>-,trail:-

" search
set ignorecase smartcase	" ignore case when search
set hlsearch				" highlight all machers
set incsearch				" instance search
set wrapscan				" wrap scan

" language
syntax enable

" recover
set updatecount=100
set updatetime=1000

" insert
set showmatch		" show match for (), {}, [] characters.
iabbrev #b /*****************
iabbrev #e <Space>*****************/

" key map
imap <C-s> <Esc>:w<CR>i
