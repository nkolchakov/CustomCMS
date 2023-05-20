import { Box, Input } from '@mui/material';
import Chip from '@mui/material/Chip';
import Paper from '@mui/material/Paper';
import { useState } from 'react';
import { EMPTY_GUID } from '../../constants';

interface ChipsArrayProps {
    initialValues: ChipData[],
    onChange: (data: ChipData[]) => void
}

export interface ChipData {
    id: string,
    value: string
}

export const ChipsArray = ({ onChange, initialValues }: ChipsArrayProps) => {
    const [newValue, setNewValue] = useState<string | null>(null);
    const [chipData, setChipData] = useState<ChipData[]>(initialValues);

    const captureOnKeyDown = (event: any) => {
        if (event.key === 'Enter') {
            event.preventDefault();
            event.stopPropagation();
            if (newValue == null || !newValue.trim()) {
                return;
            }
            if (chipData.some(c => c.value === newValue)) {
                return;
            }
            const newChip: ChipData = {
                id: EMPTY_GUID,
                value: newValue
            }
            chipData.push(newChip)
            setChipData(chipData);

            setNewValue(null);
            onChange(chipData);
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
                {chipData.map((data: ChipData, i: number) => (
                    <li
                        style={{ marginRight: 10 }}
                        key={data.value}>
                        <Chip
                            label={data.value}
                            onDelete={() => {
                                console.log('preupdate ', chipData);
                                let updated = chipData.filter(c => c.value !== data.value);
                                console.log('updated ', updated);
                                setChipData(updated);
                                onChange(updated);
                            }}
                        />
                    </li>
                ))}
            </Paper>
        </Box >
    );
}
