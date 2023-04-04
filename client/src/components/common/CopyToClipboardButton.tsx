import ContentPasteIcon from '@mui/icons-material/ContentPaste';
import { IconButton, Snackbar } from '@mui/material';
import { CSSProperties, useState } from 'react';

const CopyToClipboardButton = ({ text, style }: { text: string, style?: CSSProperties }) => {
    const [open, setOpen] = useState(false)
    const handleClick = (e: any) => {
        e.preventDefault();
        e.stopPropagation();

        setOpen(true)
        navigator.clipboard.writeText(text)
    }

    return (
        <div style={{
            display: 'inline',
            ...style
        }}>
            <IconButton onClick={handleClick}>
                <ContentPasteIcon fontSize='small' />
            </IconButton>
            <Snackbar
                anchorOrigin={{
                    vertical: 'top',
                    horizontal: 'center'
                }}
                open={open}
                onClose={() => setOpen(false)}
                autoHideDuration={2000}
                message="Copied to clipboard"
            />
        </div >
    )
}

export default CopyToClipboardButton