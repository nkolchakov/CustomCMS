import { Box, Input } from '@mui/material';
import Chip from '@mui/material/Chip';
import Paper from '@mui/material/Paper';
import { useState } from 'react';

interface ChipsArrayProps {
    initialValues: Set<string>,
    onChange: (data: string[]) => void
}

export const ChipsArray = ({ onChange, initialValues }: ChipsArrayProps) => {
    const [newValue, setNewValue] = useState<string>('');
    const [chipData, setChipData] = useState<Set<string>>(initialValues);

    const captureOnKeyDown = (event: any) => {
        if (event.key === 'Enter') {
            event.preventDefault();
            event.stopPropagation();
            if (!newValue.trim()) {
                return;
            }

            chipData.add(newValue)
            setChipData(new Set(Array.from(chipData)));

            setNewValue("");
            onChange(Array.from(chipData));
        }
    }

    const style = {
        display: 'flex',
        justifyContent: 'center',
        listStyle: 'none',
        p: 0.5,
        m: 0
    }

    return (
        <Box
            display='flex'
            flexDirection={'row'}
            columnGap={3}>
            <label htmlFor='new-list-item'>new item</label>
            <Input

                type='text'
                id='new-list-item'
                onKeyDownCapture={captureOnKeyDown}
                value={newValue}
                onChange={(event: any) => setNewValue(event.target.value?.trim())} />
            <Paper
                style={{ ...style, flexWrap: 'wrap' }}
                component="ul"
            >
                {Array.from(chipData)
                    .map((value: string) => (
                        <li
                            style={{ marginRight: 10 }}
                            key={value}>
                            <Chip
                                label={value}
                                onDelete={() => {
                                    chipData.delete(value);
                                    setChipData(new Set(Array.from(chipData)));
                                    onChange(Array.from(chipData));
                                }}
                            />
                        </li>
                    ))}
            </Paper>
        </Box >
    );
}
