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
